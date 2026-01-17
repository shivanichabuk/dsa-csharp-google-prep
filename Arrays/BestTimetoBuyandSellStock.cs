public int MaxProfit(int[] prices)
{
    int minPrice=int.MaxValue;
    int maxPrice=0;

    foreach(int price in prices)
    {
        minPrice=Math.Min(price,minPrice);
        int profit=price-minPrice;
        maxPrice=Math.Max(profit,maxPrice);
    }
    return maxProfit;
}