public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) 
    {
        int totalGas = 0, totalCost = 0;
        int currentGas = 0, startIndex = 0;
        int size = gas.Length;

        for(int i = 0; i < size; i++)
        {
            totalGas += gas[i];
            totalCost += cost[i];

            currentGas += gas[i] - cost[i];
            if(currentGas < 0)
            {
                startIndex = i +1;
                currentGas = 0;
            }
        }
        return ((totalGas<totalCost) ? -1 : startIndex);

    }
}
