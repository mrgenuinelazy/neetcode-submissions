public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // Skip non-alphanumeric characters from the left
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            // Skip non-alphanumeric characters from the right
            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            // Compare characters without considering case
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
        
    }
}
