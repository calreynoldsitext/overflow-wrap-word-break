public virtual void ConvertHTMLtoPDF() {
    ConverterProperties properties = new ConverterProperties();
    FontProvider fontProvider = new DefaultFontProvider(true, true, true);
    properties.SetFontProvider(fontProvider);
    HtmlConverter.ConvertToPdf(new FileInputStream("HTML/input_html.html"), new FileOutputStream("output_file.pdf"), properties);
}
