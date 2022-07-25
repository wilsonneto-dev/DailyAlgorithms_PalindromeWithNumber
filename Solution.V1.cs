public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        
        var chars = x.ToString().ToCharArray();
        
        var leftPointer = 0;
        var rightPointer = chars.Count() -1;
        
        while(leftPointer < rightPointer)
            if(chars[leftPointer++] != chars[rightPointer--])
                return false;
        
        return true;
    }
}
