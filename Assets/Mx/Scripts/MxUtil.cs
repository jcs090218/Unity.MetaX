/**
 * Copyright (c) Jen-Chieh Shen. All rights reserved.
 * 
 * jcs090218@gmail.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Mx
{
    public static class MxUtil
    {
        /* Variables */

        /* Setter & Getter */

        /* Functions */

        /// <summary>
        /// Construct a key to store `EditorPrefs` registry.
        /// </summary>
        public static string FormKey(string name)
        {
            return "Mx." + name;
        }

        /// <summary>
        /// Print a list in one console log.
        /// </summary>
        public static void Print(List<string> lst)
        {
            string result = "";

            foreach (string item in lst)
            {
                result += item + " ";
            }

            Debug.Log(result);
        }

        /// <summary>
        /// Get a texture from its source filename.
        /// </summary>
        public static Texture FindTexture(string texName)
        {
            Texture tex = (texName == "") ? null : EditorGUIUtility.FindTexture(texName);
            return tex;
        }

        /// <summary>
        /// Convert enum to a list with names.
        /// </summary>
        public static List<string> EnumList(Type e)
        {
            return Enum.GetNames(e).ToList();
        }

        /// <summary>
        /// Conver enum to a tuple contains two list.
        ///   - Item1 : is the name.
        ///   - Item2 : is the value.
        /// </summary>
        public static (List<string>, List<string>) EnumTuple(Type e)
        {
            List<string> names = EnumList(e);
            List<string> values = Enum.GetValues(e)
                .Cast<KeyCode>()
                .Select(i => ((int)i).ToString())
                .ToList();
            return (names, values);
        }

        /// <summary>
        /// Convert any list to list of string.
        /// </summary>
        public static List<string> ToListString<T>(List<T> lst)
        {
            return lst.Select(t => t.ToString()).ToList();
        }

        /// <summary>
        /// Cover GameObject to list of string.
        /// </summary>
        public static List<string> ToListString(List<GameObject> lst)
        {
            return lst.Select(i => i.name).ToList();
        }
    }
}
