using System;

namespace PrepareAnExam.Web.Models.HomeViewModels
{
    /*
     * https://www.wired.com/feed/rss
     <item>
        <title>...</title>
        <link>...</link>
        <guid isPermaLink="false">5d953e3086bf2a000830d07b</guid>
        <pubDate>Sat, 05 Oct 2019 14:00:00 +0000</pubDate>
        <media:content/>
        <description>...</description>
        <category>Science</category>
        <category>Science / Health</category>
        <media:keywords>Ars Technica, Archeology, nutrition</media:keywords>
        <dc:creator>Kiona N. Smith, Ars Technica</dc:creator>
        <dc:modified>Sat, 05 Oct 2019 15:37:12 +0000</dc:modified>
        <dc:publisher>Condé Nast</dc:publisher>
        <media:thumbnail url="https://media.wired.com/photos/5d97ec6ccac1be000849cd6b/master/pass/Science_ruminantmilk_158608671.jpg" width="2000" height="1333"/>
      </item>
     */
    public class RssItemViewModel
    {
        public string Link { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public RssItemViewModel()
        {
            Link = "";
            Title = "";
            Description = "";
            PublishDate = DateTime.Today;
        }
    }
}
