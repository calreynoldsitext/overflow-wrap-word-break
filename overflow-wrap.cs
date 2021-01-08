public virtual void ConvertHTMLtoPDF() {
    ConverterProperties properties = new ConverterProperties();
    FontProvider fontProvider = new DefaultFontProvider(true, true, true);
    properties.SetFontProvider(fontProvider);
    HtmlConverter.ConvertToPdf(new FileStream("HTML/input_html.html", FileMode.Open, FileAccess.Read), new FileStream("HTML/input_html.html", FileMode.Create), properties);
}
