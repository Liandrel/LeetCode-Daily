


public class SmallestInfiniteSet
{
    public SmallestInfiniteSet()
    {
        _popedNumbers = new();
        _cursor = 1;
    }
    private HashSet<int> _popedNumbers;
    private int _cursor;

    public int PopSmallest()
    {
        int output = _cursor;
        _popedNumbers.Add(output);
        for (int i = _cursor; i < int.MaxValue; i++)
        {
            if (_popedNumbers.Contains(i) == false)
            {
                _cursor = i;
                break;
            }
        }
        return output;
    }

    public void AddBack(int num)
    {
        _popedNumbers.Remove(num);
        if (num < _cursor)
            _cursor = num;
    }
}