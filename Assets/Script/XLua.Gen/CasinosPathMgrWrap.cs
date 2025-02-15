﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class CasinosPathMgrWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Casinos.PathMgr);
			Utils.BeginObjectRegister(type, L, translator, 0, 8, 13, 10);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetWWWPersistentDataPath", _m_GetWWWPersistentDataPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CombineWWWPersistentDataPath", _m_CombineWWWPersistentDataPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPersistentDataPath", _m_GetPersistentDataPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CombinePersistentDataPath", _m_CombinePersistentDataPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetStreamingAssetsPath", _m_GetStreamingAssetsPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CombineStreamingAssetsPath", _m_CombineStreamingAssetsPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetWWWStreamingAssetsPath", _m_GetWWWStreamingAssetsPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CombineWWWStreamingAssetsPath", _m_CombineWWWStreamingAssetsPath);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "PathAssets", _g_get_PathAssets);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PathSettings", _g_get_PathSettings);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PathSettingsUser", _g_get_PathSettingsUser);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirLaunchAb", _g_get_DirLaunchAb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirLaunchAbType", _g_get_DirLaunchAbType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirLuaRoot", _g_get_DirLuaRoot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirRawRoot", _g_get_DirRawRoot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirAbRoot", _g_get_DirAbRoot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirAbUi", _g_get_DirAbUi);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirAbCard", _g_get_DirAbCard);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirAbAudio", _g_get_DirAbAudio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirAbItem", _g_get_DirAbItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DirAbParticle", _g_get_DirAbParticle);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirLaunchAb", _s_set_DirLaunchAb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirLaunchAbType", _s_set_DirLaunchAbType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirLuaRoot", _s_set_DirLuaRoot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirRawRoot", _s_set_DirRawRoot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirAbRoot", _s_set_DirAbRoot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirAbUi", _s_set_DirAbUi);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirAbCard", _s_set_DirAbCard);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirAbAudio", _s_set_DirAbAudio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirAbItem", _s_set_DirAbItem);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DirAbParticle", _s_set_DirAbParticle);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<Casinos._eEditorRunSourcePlatform>(L, 2))
				{
					Casinos._eEditorRunSourcePlatform _editor_mode_runsources_platform;translator.Get(L, 2, out _editor_mode_runsources_platform);
					
					Casinos.PathMgr gen_ret = new Casinos.PathMgr(_editor_mode_runsources_platform);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Casinos.PathMgr constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWWWPersistentDataPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.GetWWWPersistentDataPath(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CombineWWWPersistentDataPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.CombineWWWPersistentDataPath( _path );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPersistentDataPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.GetPersistentDataPath(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CombinePersistentDataPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 2);
                    bool _for_lua = LuaAPI.lua_toboolean(L, 3);
                    
                        string gen_ret = gen_to_be_invoked.CombinePersistentDataPath( _path, _for_lua );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.CombinePersistentDataPath( _path );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Casinos.PathMgr.CombinePersistentDataPath!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStreamingAssetsPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.GetStreamingAssetsPath(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CombineStreamingAssetsPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.CombineStreamingAssetsPath( _path );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWWWStreamingAssetsPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.GetWWWStreamingAssetsPath(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CombineWWWStreamingAssetsPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.CombineWWWStreamingAssetsPath( _path );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PathAssets(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.PathAssets);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PathSettings(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.PathSettings);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PathSettingsUser(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.PathSettingsUser);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirLaunchAb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DirLaunchAb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirLaunchAbType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                translator.PushCasinosDirType(L, gen_to_be_invoked.DirLaunchAbType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirLuaRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DirLuaRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirRawRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DirRawRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirAbRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DirAbRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirAbUi(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DirAbUi);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirAbCard(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DirAbCard);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirAbAudio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DirAbAudio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirAbItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DirAbItem);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DirAbParticle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DirAbParticle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirLaunchAb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DirLaunchAb = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirLaunchAbType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                Casinos.DirType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.DirLaunchAbType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirLuaRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DirLuaRoot = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirRawRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DirRawRoot = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirAbRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DirAbRoot = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirAbUi(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DirAbUi = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirAbCard(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DirAbCard = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirAbAudio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DirAbAudio = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirAbItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DirAbItem = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DirAbParticle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Casinos.PathMgr gen_to_be_invoked = (Casinos.PathMgr)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DirAbParticle = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
