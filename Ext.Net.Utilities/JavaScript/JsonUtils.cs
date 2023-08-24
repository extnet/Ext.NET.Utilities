﻿/*
 * @version   : 2.5.0
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2014-10-20
 * @copyright : Copyright (c) 2008-2014, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 * @website   : http://www.ext.net/
 */

using System.Text;

namespace Ext.Net.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonUtils
    {
        //  Public Domain 2002 JSON.org
        //  @author JSON.org
        //  @version 0.1
        //  Ported to C# by Are Bjolseth, teleplan.no
        /// <summary>
        /// Produce a string in double quotes with backslash sequences in all the right places.
        /// </summary>
        /// <param name="s">A String</param>
        /// <returns>A String correctly formatted for insertion in a JSON message.</returns>
        public static string Enquote(string s)
        {
            if (s == null || s.Length == 0)
            {
                return "\"\"";
            }
            char c;
            int i;
            int len = s.Length;
            StringBuilder sb = new StringBuilder(len + 4);
            string t;

            sb.Append('"');
            for (i = 0; i < len; i += 1)
            {
                c = s[i];
                if ((c == '\\') || (c == '"') || (c == '>'))
                {
                    sb.Append('\\');
                    sb.Append(c);
                }
                else if (c == '\b')
                    sb.Append("\\b");
                else if (c == '\t')
                    sb.Append("\\t");
                else if (c == '\n')
                    sb.Append("\\n");
                else if (c == '\f')
                    sb.Append("\\f");
                else if (c == '\r')
                    sb.Append("\\r");
                else
                {
                    if (c < ' ')
                    {
                        sb.Append("\\u" + ((int) c).ToString("x4", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }
            sb.Append('"');

            return sb.ToString();
        }
    }
}
