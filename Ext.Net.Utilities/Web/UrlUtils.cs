/*
 * @version   : 2.3.0
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2013-10-04
 * @copyright : Copyright (c) 2008-2013, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 * @website   : http://www.ext.net/
 */

namespace Ext.Net.Utilities
{
    public class UrlUtils
    {
        public static bool IsUrl(string url)
        {
            return (!string.IsNullOrEmpty(url) && url.IndexOf("://") >= 0);
        }
    }
}
