#include "stdafx.h"
#include <map>
#include "ShimProxyFactory.h"
#include "Vars.hpp"
#include "DllRegister32.h"
#include "DllRegister64.h"
#include "DllRegister32On64.h"
#include "ShimArguments.h"

HANDLE						_thread				= NULL;		// DLL module create thread
HINSTANCE					_module				= NULL;		// DLL module handle
ULONG						_components			= 0;		// Count of open instances
ULONG						_locks				= 0;		// Count of server locks
BOOL						_unloadAllowed		= TRUE;		// determines unload is ok
std::map<LPCWSTR, ULONG>	_componentsMap;					// Identifies open instances

bool Is64BitWindows(bool & isWindows64bit);

BOOL APIENTRY DllMain(HMODULE hModule,DWORD  ul_reason_for_call, LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	{
		ShimProxy_Host_Application = new LPCWSTR[1];
		ShimProxy_Host_Application[0] = L"PowerPoint";
		_module = hModule;
		_thread = GetCurrentThread();
		//::DisableThreadLibraryCalls(hModule);
		//ShimArguments* args = new ShimArguments();
		//args->Load();
		//delete args;
		break;
	}
	case DLL_THREAD_ATTACH:
	{
		break;
	}
	case DLL_THREAD_DETACH:
	{
		break;
	}
	case DLL_PROCESS_DETACH:
	{
		if (ShimProxy_Host_Application)
		{
			delete[] ShimProxy_Host_Application;
			ShimProxy_Host_Application = NULL;
		}
		break;
	}
	}
	return TRUE;
}

STDAPI DllCanUnloadNow()
{
	HRESULT hr = (_components == 0 && _locks == 0) ? S_OK : S_FALSE;

#ifdef DEBUG

	// this is a check to avoid heap leaks
	// every class in ShimLoader increment a static counter(_components) in ctor and decrement them in dtor
	// if this global counter is not 0 before the dll is forced to unload means the ShimLoader is kind of a spit.
	// _unloadAllowed is because the host application check for unload in Idle time
	// TODO: create a common base class to increment/decrement this counter and let all classes in ShimLoader inherit from
	if (!SUCCEEDED(hr) && _unloadAllowed)
	{
		WCHAR szBuffer[128];
		wsprintf(szBuffer, L"Unexpected: %ld components left.", _components);
		MessageBox(GetDesktopWindow(), szBuffer, L"DllCanUnloadNow", 0);
	}

#endif

	return hr;
}

STDAPI DllGetClassObject(REFCLSID rclsid, REFIID riid, void** ppv)
{
	*ppv = NULL;

	if (rclsid != ShimProxy_CLSID)
		return CLASS_E_CLASSNOTAVAILABLE;

	ShimProxyFactory* pCF = new (std::nothrow) ShimProxyFactory();
	if (NULL == pCF)
		return E_OUTOFMEMORY;

	HRESULT hr = pCF->QueryInterface(riid, ppv);
	if (FAILED(hr))
	{
		*ppv = NULL;
		delete pCF;
	}

	return hr;
}

STDAPI DllRegisterServer()
{
	HRESULT hr = S_OK;

	if (ENABLE_SELF_REGISTRATION)
	{
		try
		{
#if X64BUILD

			//hr = NetOffice_ShimLoader_Register64::DllRegister(
			//	_module,
			//	ShimProxy_Host_Application,
			//	ShimProxy_LoadBehavior,
			//	ShimProxy_CommandLineSafe,
			//	ShimProxy_ProgID,
			//	ShimProxy_CLSID_Text,
			//	ShimProxy_FriendlyName,
			//	ShimProxy_Description,
			//	ShimProxy_Version,
			//	static_cast<RegisterMode>(SELF_REGISTER_MODE));

#else

			bool is64BitWindows = false;
			if (Is64BitWindows(is64BitWindows))
			{
				if (is64BitWindows)
				{
					IfFailGo(NetOffice_ShimLoader_Register32On64::DllRegister(
						_module,
						ShimProxy_Host_Application,
						ShimProxy_LoadBehavior,
						ShimProxy_CommandLineSafe,
						ShimProxy_ProgID,
						ShimProxy_CLSID_Text,
						ShimProxy_FriendlyName,
						ShimProxy_Description,
						ShimProxy_Version,
						static_cast<RegisterMode>(SELF_REGISTER_MODE)));
				}
				else
				{
					/*hr = NetOffice_ShimLoader_Register32::DllRegister(
					_module,
					ShimProxy_Host_Application,
					ShimProxy_LoadBehavior,
					ShimProxy_CommandLineSafe,
					ShimProxy_ProgID,
					ShimProxy_CLSID_Text,
					ShimProxy_FriendlyName,
					ShimProxy_Description,
					ShimProxy_Version,
					static_cast<RegisterMode>(SELF_REGISTER_MODE));*/
				}
			}
			else
			{
				hr = E_UNEXPECTED;
				goto Error;
			}

#endif
		}
		catch (...)
		{
			hr = E_FAIL;
			goto Error;
		}
	}

	return hr;

Error:

	return hr;
}

STDAPI DllUnregisterServer()
{
	HRESULT hr = S_OK;

	if (ENABLE_SELF_REGISTRATION)
	{
		try
		{
#if X64BUILD

			//hr = NetOffice_ShimLoader_Register64::DllUnregister(
			//	ShimProxy_Host_Application,
			//	ShimProxy_ProgID,
			//	ShimProxy_CLSID_Text,
			//	ShimProxy_Version,
			//	static_cast<RegisterMode>(SELF_REGISTER_MODE));

#else

			bool is64BitWindows = false;
			if (Is64BitWindows(is64BitWindows))
			{
				if (is64BitWindows)
				{
					IfFailGo(NetOffice_ShimLoader_Register32On64::DllUnregister(
						ShimProxy_Host_Application,
						ShimProxy_ProgID,
						ShimProxy_CLSID_Text,
						ShimProxy_Version,
						static_cast<RegisterMode>(SELF_REGISTER_MODE)));
				}
				else
				{
					//hr = NetOffice_ShimLoader_Register32::DllUnregister(
					//	ShimProxy_Host_Application,
					//	ShimProxy_ProgID,
					//	ShimProxy_CLSID_Text,
					//	ShimProxy_Version,
					//	static_cast<RegisterMode>(SELF_REGISTER_MODE));
				}

			}
			else
			{
				hr = E_UNEXPECTED;
				goto Error;
			}

#endif
		}
		catch (...)
		{
			hr = E_FAIL;
			goto Error;
		}
	}

	return hr;

Error:

	return hr;
}

bool Is64BitWindows(bool & isWindows64bit)
{
#if _WIN64

	isWindows64bit = true;
	return true;

#elif _WIN32

	BOOL isWow64 = FALSE;
	LPFN_ISWOW64PROCESS fnIsWow64Process = (LPFN_ISWOW64PROCESS)GetProcAddress(GetModuleHandle(TEXT("kernel32")), "IsWow64Process");

	if (fnIsWow64Process)
	{
		if (!fnIsWow64Process(GetCurrentProcess(), &isWow64))
			return false;

		if (isWow64)
			isWindows64bit = true;
		else
			isWindows64bit = false;

		return true;
	}
	else
		return false;

#else

	assert(0);
	return false;

#endif
}

void IncComponents(LPCWSTR type)
{
#ifdef DEBUG
	_componentsMap[type] = ++_componentsMap[type];
#endif
	_components++;
}

void DecComponents(LPCWSTR type)
{
#ifdef DEBUG
	_componentsMap[type] = --_componentsMap[type];
	if (_componentsMap[type] == 0)
		_componentsMap.erase(type);
#endif
	_components--;
}