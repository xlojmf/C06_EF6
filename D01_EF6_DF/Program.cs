using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_EF6_DF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // atenção que estamos a escrever na bd e depois a gravar ois registos ja existem!!!!!

            Utility.SetUnicodeConsole();

            #region Declarar o contexto de db
            var db = new NorthwindEntities(); // aceder a connection string e aos dbsets
            #endregion

            #region Usar o contexto de bd
            using (db) 
            {
                #region New Region (1)
                Region region= new Region();

                region.RegionID= 9;// nao é identity
                region.RegionDescription = "Norte";
                db.Region.Add(region); // adiciona o novo registo a tabela em memoria ao dbset 
                //para adicionar novas regions temos q criar novas instancias?

                db.SaveChanges(); // salva e guarda na base de dados as mudanças

                //int countRows = db.SaveChanges();
                //Console.WriteLine(countRows);

                //Listar com linq as regioes id descrition
                var queryRegion = db.Region.Select(r => r).OrderBy(r => r.RegionID).ToList();

                foreach ( var r in queryRegion ) 
                { 
                Console.WriteLine($"{r.RegionID} - {r.RegionDescription}");
                }

                #endregion

                #region New Territory da region (n)

                Territories territories = new Territories();
                territories.TerritoryID = "9051";
                territories.RegionID = 9;
                territories.TerritoryDescription = "Porto";

                db.Territories.Add(territories); 

                db.SaveChanges();
                
                var queryTerritory = db.Territories.Select(t=>t).ToList();
                /*
                foreach (var item in queryTerritory)
                {
                    Console.WriteLine($"{item.RegionID} - {item.Region.RegionDescription} - {item.TerritoryID} - {item.TerritoryDescription} ");
                }*/

                // linq foreach
                queryTerritory.ToList().ForEach(item => Console.WriteLine($"{item.RegionID} - {item.Region.RegionDescription} - {item.TerritoryID} - {item.TerritoryDescription}"));

                #endregion


            }

            #endregion

            #region 

            #endregion

            Utility.TerminateConsole();

        }
    }
}
