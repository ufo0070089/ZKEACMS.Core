﻿/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */
using Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZKEACMS
{
    public class ApplicationContextAccessor : IApplicationContextAccessor
    {
        private readonly CMSApplicationContext _applicationContext;
        public ApplicationContextAccessor(IApplicationContext applicationContext)
        {
            _applicationContext = applicationContext as CMSApplicationContext;
        }
        public CMSApplicationContext Current
        {
            get
            {
                return _applicationContext;
            }
        }
    }
}
