using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kamzik.Models.CoreModules
{
    public class Storages
    {
        private static Storages storageInstance = null;
        private static PrimaryEntities defaultConnection = new PrimaryEntities();

        public Storages()
        {
            _createAndMapStorage();
        }

        public static PrimaryEntities mapStorages()
        {
            return defaultConnection;
        }

        public static Storages _createAndMapStorage()
        {
            if (storageInstance == null)
                storageInstance = new Storages();
            return storageInstance;
        }
    }
}