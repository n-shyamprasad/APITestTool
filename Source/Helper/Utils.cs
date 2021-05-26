using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text.Json;

namespace Helper
{
    public class Utils
    {
        public static string GetConfig(string skey)
        {
            string sValue = string.Empty;
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            if (appSettings[skey] != null)
                sValue = appSettings[skey];
            return sValue;
        }

        public static string[] getFiles(string SourceFolder, string Filter, System.IO.SearchOption searchOption)
        {
            ArrayList alFiles = new ArrayList();
            string[] MultipleFilters = Filter.Split('|');
            foreach (string FileFilter in MultipleFilters)
            {
                alFiles.AddRange(Directory.GetFiles(SourceFolder, "*." + FileFilter, searchOption));
            }
            return (string[])alFiles.ToArray(typeof(string));
        }

        private const string INDENT_STRING = "   ";
        public static string FormatJson(string str)
        {
            var indent = 0;
            var quoted = false;
            var sb = new StringBuilder();
            for (var i = 0; i < str.Length; i++)
            {
                var ch = str[i];
                switch(ch)
                {
                    case '{':
                    case '[':
                        sb.Append(ch);
                        if(!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, ++indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        break;
                    case '}':
                    case ']':
                        sb.Append(ch);
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, --indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        break;
                    case '"':
                        sb.Append(ch);
                        bool escaped = false;
                        var index = i;
                        while (index > 0 && str[--index] == '\\')
                            escaped = !escaped;
                        if (!escaped)
                            quoted = !quoted;
                        break;
                    case ',':
                        sb.Append(ch);
                        if(!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        break;
                    case ':':
                        sb.Append(ch);
                        if (!quoted)
                            sb.Append(" ");
                        break;
                    default:
                        sb.Append(ch);
                        break;
                }
            }               
            return sb.ToString();
        }
    }
    static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
        {
            foreach (var item in ie)
            {
                action(item);
            }
        }

        public static string ToJson(this string stringData)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(stringData);
            return JsonSerializer.Serialize(jsonElement, options);
        }
    }
}
