using System;

namespace XMCM
{
    public static class Lipsum
    {
        //* Constants
        private const string BASE = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ullamcorper ligula quis nisl varius, vitae tincidunt libero dapibus. Nunc vel nunc elit. Etiam aliquet nec ligula eget pretium. Ut non arcu sem. Fusce et auctor dui. Mauris in lorem sit amet massa varius finibus et at metus. Aliquam non mi non justo malesuada suscipit. Etiam tincidunt ullamcorper sodales. Suspendisse potenti. Etiam ut fringilla risus. Cras varius neque metus, ac laoreet mauris commodo a.";

        //* Private Properties
        private static readonly Random Random = new Random();

        //* Public Methods
        public static string Get(int? length = null) =>
            BASE.Substring(0, Random.Next(length ?? BASE.Length));
    }
}