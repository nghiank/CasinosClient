// Copyright (c) Cragon. All rights reserved.

namespace Casinos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using UnityEngine;
    using UnityEngine.Networking;
    using ILRuntime.Runtime.Enviorment;

    public class MbLaunch : MonoBehaviour
    {
        CasinosContext Context { get; set; }
        
        public static MbLaunch Instance { get; private set; }
        public ILTypeKeeper Keeper { get; set; } = new ILTypeKeeper();
        ILRuntime.Runtime.Enviorment.AppDomain AppDomain { get; set; } = null;
        bool LoadPdb { get; set; }// 是否加载Pdb，Pdb可以用于显示出错行号
        MemoryStream MsScriptDll { get; set; }
        MemoryStream MsScriptPdb { get; set; }

        //---------------------------------------------------------------------
        public void Close()
        {
            OnDestroy();
        }

        //---------------------------------------------------------------------
        public void Init()
        {
            Start();
        }

        //---------------------------------------------------------------------
        private void Awake()
        {
            Instance = this;
        }

        //---------------------------------------------------------------------
        private void Start()
        {
            Debug.Log("MbLaunch.Start()");


            if (string.IsNullOrEmpty(launch_ver))
            {
                StartCoroutine(_copyStreamingAssets2PersistentAsync(_launch));
            }
            else
            {
                _launch();
            }
        }

        //---------------------------------------------------------------------
        private void Update()
        {            
        }

        //---------------------------------------------------------------------
        private void OnDestroy()
        {
            Debug.Log("MbLaunch.OnDestroy()");
        }

        //-------------------------------------------------------------------------
        private void OnApplicationPause(bool pause)
        {
        }

        //-------------------------------------------------------------------------
        private void OnApplicationFocus(bool focus_status)
        {
        }

    //---------------------------------------------------------------------
        void _launch()
        {
#if UNITY_EDITOR
            // 检测Script.CSharp.dll是否存在，如不存在则给出提示
#endif
            string platform = "Android";
            bool is_editor = false;
#if UNITY_STANDALONE_WIN
            platform = "PC";
#elif UNITY_ANDROID && UNITY_EDITOR
            platform = "Android";
#elif UNITY_ANDROID
            platform = "Android";
#elif UNITY_IPHONE
            platform = "iOS";
#endif

#if UNITY_EDITOR
            is_editor = true;            
#else
            is_editor = false;
#endif

            bool is_editor_debug = false;
#if UNITY_EDITOR
            EditorCfgUserSettingsCopy cfg_usersettings = null;
            string p = Path.Combine(Environment.CurrentDirectory, "./Assets/SettingsUser/");
            var di = new DirectoryInfo(p);
            string path_settingsuser = di.FullName;

            string full_filename = Path.Combine(path_settingsuser, StringDef.FileEditorUserSettings);
            if (File.Exists(full_filename))
            {
                using (StreamReader sr = File.OpenText(full_filename))
                {
                    string s = sr.ReadToEnd();
                    cfg_usersettings = JsonUtility.FromJson<EditorCfgUserSettingsCopy>(s);
                }
            }

            if (cfg_usersettings != null)
            {
                is_editor_debug = cfg_usersettings.IsEditorDebug;
            }
#endif
            Context = new CasinosContext(is_editor_debug);
            Context.Launch();
        }
    }
}
