namespace CSharp.LeetCode._1603;

//1603. Design Parking System
//https://leetcode.com/problems/design-parking-system/description/
public class ParkingSystem {
    private readonly int[] _parking;

    public ParkingSystem(int big, int medium, int small) {
        _parking = new int[]{big,medium,small};
    }
    
    public bool AddCar(int carType) {
        if(_parking[carType-1]>0){
            _parking[carType-1]--;
            return true;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */