using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ToyCorner.Models;

namespace ToyCorner.Code
{
    public static class DataSets
    {
        public static IEnumerable<ItemType> getTypeList()
        {
            // Hosted Database
            using (var conn = Connections.Conn_Host4ASP("2012Honda"))

            // Local Database
            //using (var conn = Connections.Conn_Local())
            {
                conn.Open();
                var typeList = conn.Query<ItemType>("SELECT DISTINCT t.TypeID, t.TypeName, t.TypeDescription FROM tc.tblTypes t JOIN tc.tblItems i ON t.TypeName = i.TypeName WHERE i.IsAvailable = 1 ORDER BY t.TypeName");
                typeList = typeList.OrderBy(ItemType => ItemType.TypeDescription);
                return typeList;
            }
        }

        public static IEnumerable<Item> getItemList(int TypeID)
        {
            // Hosted Database
            using (var conn = Connections.Conn_Host4ASP("2012Honda"))

            // Local Database
            //using (var conn = Connections.Conn_Local())
            {
                conn.Open();

                var items = conn.Query<Item>("SELECT DISTINCT t.TypeName, t.TypeDescription, ItemID, ItemName, ItemDescription, ItemPrice FROM tc.tblItems i JOIN tc.tblTypes t on i.TypeName = t.TypeName WHERE t.TypeID = @TypeID ORDER BY ItemName", new { TypeID = TypeID });
                foreach (var item in items)
                {
                    item.ItemImages = conn.Query<string>("SELECT DISTINCT ImageFileName FROM tc.tblImages i WHERE ItemName = @itemName", new { itemName = item.ItemName });
                }
                return items;
            }
        }

        public static Item getItem(int ItemID)
        {
            // Hosted Database
            using (var conn = Connections.Conn_Host4ASP("2012Honda"))

            // Local Database
            //using (var conn = Connections.Conn_Local())
            {
                conn.Open();

                var items = conn.Query<Item>("SELECT DISTINCT t.TypeID, t.TypeName, t.TypeDescription, ItemID, ItemName, ItemDescription, ItemPrice FROM tc.tblItems i JOIN tc.tblTypes t on i.TypeName = t.TypeName WHERE i.ItemID = @ItemID", new { ItemID = ItemID });
                foreach (var item in items)
                {
                    item.ItemImages = conn.Query<string>("SELECT DISTINCT ImageFileName FROM tc.tblImages i WHERE ItemName = @itemName", new { itemName = item.ItemName });
                }
                return items.ElementAt(0);
            }

        //public static IEnumerable<ItemType> getTypeList()
        //{
        //    // Hosted Database
        //    //using (var conn = Connections.Conn_Host4ASP("2012Honda"))

        //    // Local Database
        //    using (var conn = Connections.Conn_Local())
        //    {
        //        conn.Open();
        //        var typeList = conn.Query<ItemType>("SELECT DISTINCT t.TypeID, t.TypeName, t.TypeDescription FROM tblTypes t JOIN tblItems i ON t.TypeName = i.TypeName WHERE i.IsAvailable = 1 ORDER BY t.TypeName");
        //        typeList = typeList.OrderBy(ItemType => ItemType.TypeDescription);
        //        return typeList;
        //    }
        //}

        //public static IEnumerable<Item> getItemList(int TypeID)
        //{
        //    // Hosted Database
        //    //using (var conn = Connections.Conn_Host4ASP("2012Honda"))

        //    // Local Database
        //    using (var conn = Connections.Conn_Local())
        //    {
        //        conn.Open();

        //        var items = conn.Query<Item>("SELECT DISTINCT t.TypeName, t.TypeDescription, ItemID, ItemName, ItemDescription, ItemPrice FROM tblItems i JOIN tblTypes t on i.TypeName = t.TypeName WHERE t.TypeID = @TypeID ORDER BY ItemName", new { TypeID = TypeID });
        //        foreach (var item in items)
        //        {
        //            item.ItemImages = conn.Query<string>("SELECT DISTINCT ImageFileName FROM tblImages i WHERE ItemName = @itemName", new { itemName = item.ItemName });
        //        }
        //        return items;
        //    }
        //}

        //public static Item getItem(int ItemID)
        //{
        //    // Hosted Database
        //    //using (var conn = Connections.Conn_Host4ASP("2012Honda"))

        //    // Local Database
        //    using (var conn = Connections.Conn_Local())
        //    {
        //        conn.Open();

        //        var items = conn.Query<Item>("SELECT DISTINCT t.TypeID, t.TypeName, t.TypeDescription, ItemID, ItemName, ItemDescription, ItemPrice FROM tblItems i JOIN tblTypes t on i.TypeName = t.TypeName WHERE i.ItemID = @ItemID", new { ItemID = ItemID });
        //        foreach (var item in items)
        //        {
        //            item.ItemImages = conn.Query<string>("SELECT DISTINCT ImageFileName FROM tblImages i WHERE ItemName = @itemName", new { itemName = item.ItemName });
        //        }
        //        return items.ElementAt(0);
        //    }

        }
    }
}