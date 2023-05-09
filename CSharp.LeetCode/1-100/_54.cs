namespace CSharp.LeetCode._1_100._54;

//54. Spiral Matrix
//https://leetcode.com/problems/spiral-matrix/description/
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var colStartIndex = 0;
        var colEndIndex = matrix[0].Length-1;
        var rowStartIndex = 0;
        var rowEndIndex = matrix.Length-1;
        var total = matrix.Length * matrix[0].Length;
        var count = 0;
        var result = new List<int>(total);

        while(count < total){

            for(var j = colStartIndex; j<=colEndIndex && count < total;j++){
                result.Add(matrix[rowStartIndex][j]);
                count++;
            }
            rowStartIndex++;

            for(var i = rowStartIndex; i <=rowEndIndex && count < total;i++){
                result.Add(matrix[i][colEndIndex]);
                count++;
            }
            colEndIndex--;

            for(var j = colEndIndex; j>=colStartIndex && count < total;j--){
                result.Add(matrix[rowEndIndex][j]);
                count++;
            }
            rowEndIndex--;

            for(var i = rowEndIndex; i >= rowStartIndex && count < total;i--){
                result.Add(matrix[i][colStartIndex]);
                count++;
            }
            colStartIndex++;
        }

        return result;
    }
}