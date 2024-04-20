using System;
using System.IO;
using UnityEngine;

namespace Core
{
    public static class DataManager
    {
        public static PlayerData PlayerData = null;
        private const string DATA_FILE_NAME = "UserData.data";

        private static string fullPath => Path.Combine(Application.persistentDataPath, DATA_FILE_NAME);

        public static void LoadData()
        {
            if (File.Exists(fullPath))
            {
                try
                {
                    string dataToLoad = "";
                    using (FileStream readStream = new FileStream(fullPath, FileMode.Open))
                    {
                        using (StreamReader reader = new StreamReader(readStream))
                        {
                            dataToLoad = reader.ReadToEnd();
                        }
                    }

                    PlayerData = JsonUtility.FromJson<PlayerData>(dataToLoad);
                }
                catch (Exception err)
                {
                    Debug.Log($"error with loading data : {err.Message}");
                }
            }
            else
            {
                PlayerData = new PlayerData();
                PlayerData.CreateData();
            }
        }

        public static void SaveData()
        {
            try
            {
                Directory.CreateDirectory(Application.persistentDataPath);
                string dataToStore = JsonUtility.ToJson(PlayerData, true);

                using (FileStream writeStream = new FileStream(fullPath, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(writeStream))
                    {
                        writer.Write(dataToStore);
                    }
                }
            }
            catch (Exception err)
            {
                Debug.Log($"error with saving data : {err.Message}");
            }
        }
    }
}