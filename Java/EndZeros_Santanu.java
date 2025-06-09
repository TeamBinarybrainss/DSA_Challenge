import java.util.Arrays;

public class EndZeros_Santanu {
    public static void main(String[] args) {
        int[] arr = {0, 98, 23, 0, 4, 2, 0, 78};
        pushZerosToEnd(arr); // Call the method to modify the array
        System.out.println(Arrays.toString(arr)); // Print the modified array
    }

    public static void pushZerosToEnd(int[] arr) { // Added parameter
        if (arr == null || arr.length == 0) return;

        int i = 0;

        // Move all non-zero elements to the front
        for (int j = 0; j < arr.length; j++) {
            if (arr[j] != 0) {
                arr[i++] = arr[j];
            }
        }

        // Fill remaining positions with zeros
        while (i < arr.length) {
            arr[i++] = 0;
        }
    }
}