using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider;

namespace MvcSiteMapProvider_MultiCategory
{
    public class ProductNodeProvider : DynamicNodeProviderBase
    {
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            //string parent = "";
            //if (node.Attributes.ContainsKey("parentNode"))
            //{
            //    parent = node.Attributes["parentNode"].ToString();
            //}
            //List<ProductModel> products = DataServices.GetActiveProductBySubType(parent, node.Key);


            //var returnValue = new List<DynamicNode>();
            //foreach (ProductModel p in products)
            //{
            //    DynamicNode dnode = new DynamicNode();
            //    dnode.Title = p.ProductName;
            //    dnode.Action = "Details";
            //    dnode.Controller = "Products";
            //    dnode.RouteValues.Add("id", p.ProductId);

            //    returnValue.Add(dnode);
            //}
            //return returnValue;

            // For demonstration purposes, we are considering the canonical URL to be
            // the one under the BridalRings category.
            bool isCanonical = node.Attributes.ContainsKey("category") && "BridalRings".Equals(node.Attributes["category"]);
            

            DynamicNode dnode1 = new DynamicNode();
            dnode1.Title = "Product 1";
            dnode1.Action = "Details";
            dnode1.Controller = "Products";
            dnode1.RouteValues.Add("id", 1);
            SetCanonicalKey(dnode1, isCanonical);

            yield return dnode1;


            DynamicNode dnode2 = new DynamicNode();
            dnode2.Title = "Product 2";
            dnode2.Action = "Details";
            dnode2.Controller = "Products";
            dnode2.RouteValues.Add("id", 2);
            SetCanonicalKey(dnode2, isCanonical);

            yield return dnode2;


            DynamicNode dnode3 = new DynamicNode();
            dnode3.Title = "Product 3";
            dnode3.Action = "Details";
            dnode3.Controller = "Products";
            dnode3.RouteValues.Add("id", 3);
            SetCanonicalKey(dnode3, isCanonical);

            yield return dnode3;
        }

        // Determine canonical (primary) category for the product
        // for the canonical tag. We set the Key of the "master"
        // source of the content and the CanonicalKey for all of the copies.
        private void SetCanonicalKey(DynamicNode dnode, bool isCanonical)
        {
            string canonicalKey = "Canonical|" + dnode.Title;
            if (isCanonical)
                dnode.Key = canonicalKey;
            else
                dnode.CanonicalKey = canonicalKey;
        }
    }
}