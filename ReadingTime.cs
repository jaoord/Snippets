// simple .net core MVC Extension that returns a text string with the expected reading time

public static string ReadingTime(this IHtmlHelper helper, string text, int wordsPerMinute = 200)
{
    char[] delimiters = new char[] { ' ', '\r', '\n' };
    int numberOfWords = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

    int readingTime = (int)Math.Ceiling((double)numberOfWords / wordsPerMinute);

    if (readingTime <= 1)
    {
        return "1 minuut";
    }
    else
    {
        return $"{readingTime} minuten";
    }
}