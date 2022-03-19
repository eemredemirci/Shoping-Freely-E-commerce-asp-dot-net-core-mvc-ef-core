using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ShoppingFreelyMVC.Extensions
{
    public static class ImageExtension
    {
        public static IHtmlContent ImageToBase64(this IHtmlHelper helper, byte[] image)
        {
            var img = String.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(image));
            return new HtmlString("<img class='w3-round-xlarge' src='" + img + "' />");
        }
        public static IHtmlContent ProductCard(this IHtmlHelper helper, byte[] image,string productName)
        {
            var img = String.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(image));
            string html = "" +
                "<div class='w3-third'>" +
                "<div class='w3-card' align='center'>" +
                "<img style='width:100px;height:150px;margin-top: 0px;padding-top: 15px;' src='" + img + "' />" +
                "<div class='w3-container'>" +
                "<h5>"+ productName + "</h5>" +
                "</div></div></div>";
            return new HtmlString(html);
        }

    }
}
