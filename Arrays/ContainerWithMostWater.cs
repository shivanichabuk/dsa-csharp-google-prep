// LeetCode: Container With Most Water
// Pattern: Two Pointers
// Time Complexity: O(n)
// Space Complexity: O(1)
// Key Insight: Area is limited by the shorter height, so always move the smaller pointer.

public int maxarea(int[] height)
{
    int left=0;
    int right=height.Length-1;
    int maxArea=0;

    while(left<right)
    {
        int width=right-left;
        int minHeight=Math.Min(Height[left],Height[right]);
        int area=width*minHeight;

        maxArea=Math.max(area,maxArea);

        if(Height[left]<Height[right])
        {
            left++;
        }
        else{
            right--;
        }
    }
    return maxArea;
}