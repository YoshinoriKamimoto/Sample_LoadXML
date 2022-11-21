using System.Linq;
using System.Xml.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        //xmlファイルを読み込む
        XElement xml = XElement.Load(@"C:\Users\kamimoto\Desktop\work\tmp\Sample\XML\Sample.xml");

        // pokemonタグの情報を取得
        IEnumerable<XElement> infos = from item in xml.Elements("pokemon") select item;

        //要素数分ループして、コンソールに表示
        foreach (XElement info in infos)
        {
            Console.WriteLine("<name>" + info.Element("name").Value);
            Console.WriteLine("<type>" + info.Element("type").Value);
            Console.WriteLine("<lv>" + info.Element("lv").Value);
            Console.WriteLine("=======================");
        }
    }
}