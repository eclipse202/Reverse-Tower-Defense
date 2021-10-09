using UnityEngine;

public static class StringExtensions
{
    /// <summary>
    /// Copies a string to the computer's clipboard. For use in testing
    /// </summary>
    /// <param name="str"></param>
    public static void CopyToClipboard(this string str)
    {
        GUIUtility.systemCopyBuffer = str;
    }
}