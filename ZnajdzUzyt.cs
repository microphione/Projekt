using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using ListaZakupow;
namespace ListaZakupow
{

    public partial class ListaZakupowEntities
    {
        [DbFunction("EntityModels.Store", "ZnajdzUzyt")]
        public string ZnajdzUzyt(string login, string haslo)
        {
            var objectContext = ((IObjectContextAdapter)this).ObjectContext;

            var parameters = new List<ObjectParameter>();
            parameters.Add(new ObjectParameter("Login", login));
            parameters.Add(new ObjectParameter("Haslo", haslo));

            return objectContext.CreateQuery<string>("ListaZakupowModel.Store.ZnajdzUzyt(@Login, @Haslo)", parameters.ToArray())
                 .Execute(MergeOption.NoTracking)
                 .FirstOrDefault();
        }
    }
}