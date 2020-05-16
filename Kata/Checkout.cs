using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Kata
{
    public class Checkout
    {
        private List<Item> items = new List<Item>();
        private readonly Offer[] offers = { new Offer("A99", 3, 1.30m), new Offer("B15", 2, 0.45m) };
        public decimal Total()
        {
            var offersAccepted = new List<Offer>();
            var itemsNotInOffer = new List<Item>();
            foreach(var offer in offers)
            {
                var foundItems = items.Where(o => o.Sku == offer.Sku).Count();
                var offerCount = foundItems / offer.Quantity;
                var itemsNotInOfferCount = foundItems % offer.Quantity;
                if(offerCount > 0)
                {
                    for(int i = 0; i < offerCount; i++)
                    {
                        offersAccepted.Add(offer);
                    }
                }
                itemsNotInOffer.AddRange(items.Where(o => o.Sku == offer.Sku).Take(itemsNotInOfferCount));
            }
            var skusInOffers = offers.Select(o => o.Sku);
            var itemsSkuNotInOffers = items.Where(i => !skusInOffers.Contains(i.Sku));
            itemsNotInOffer.AddRange(itemsSkuNotInOffers);
            return offersAccepted.Sum(o => o.Price) + itemsNotInOffer.Sum(i => i.Price);
        }

        public void Scan(Item item)
        {
            items.Add(item);
        }
    }
}
