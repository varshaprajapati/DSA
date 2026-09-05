/*
 * Problem: Stock Buy and Sell - Max One Transaction
 *
 * Given an array of stock prices, find the maximum profit
 * possible by buying once and selling once.
 *
 * The stock must be bought before it is sold.
 * If no profit is possible, return 0.
 *
 * Example:
 * Input:  [7, 10, 1, 3, 6, 9, 2]
 * Output: 8
 *
 * --------------------------------------------------
 * Approach: Track Minimum Price
 * --------------------------------------------------
 *
 * For every day, assume we sell the stock today.
 *
 * To maximize today's profit, we should have bought at
 * the lowest price seen before today.
 *
 *     profit = currentPrice - minimumPrice
 *
 * While traversing the array, maintain:
 *
 * 1. minimumPrice -> lowest price seen so far
 * 2. maximumProfit -> maximum profit found so far
 *
 * This allows us to solve the problem in one pass.
 *
 * --------------------------------------------------
 * Key Concept:
 * Minimum/Maximum So Far Pattern
 *
 * Instead of comparing every possible pair of days,
 * maintain the best value seen so far and use it with
 * the current element.
 *
 * --------------------------------------------------
 * Time Complexity: O(n)
 * Space Complexity: O(1)
 * 
 * 
 * Naive Approach (Brute Force) ----------
 *  
 *  Time Complexity: O(n2)
 *  Space Complexity: O(1)
 * 
 * 
 * 
 */




namespace DSA.Arrays
{
    public class StockBuyandSell
    {
        public int maxProfit(int[] prices)
        {

            // Brute Force Approach

            //int n = prices.Length;
            //int res = 0;

            //// Explore all possible ways to buy and sell stock
            //for (int i = 0; i < n - 1; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        res = Math.Max(res, prices[j] - prices[i]);
            //    }
            //}
            //return res;

            // --------------------------------------------------------------------------------------------------------------'

            // Optimized Approach

            int minimumPrice = prices[0];
            int maximumProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                int currentProfit = prices[i] - minimumPrice;

                maximumProfit = Math.Max(maximumProfit, currentProfit);

                minimumPrice = Math.Min(minimumPrice, prices[i]);
            }

            return maximumProfit;

        }
    }
}
