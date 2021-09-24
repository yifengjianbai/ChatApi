using System;
using System.Collections.Generic;
using System.Text;

namespace DbService
{
    public class DbContextHelper
    {
        private static DbContextHelper instance = null;
        public static DbContextHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbContextHelper();
                }

                return instance;
            }
        }
        public RpDbContext DbContext
        {
            get
            {
                return new RpDbContext();
            }
        }
    }
}
