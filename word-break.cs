public virtual void ConvertHTMLtoPDF() {
    FontProvider fontProvider = new FontProvider();
    FontProgram fontProgram = FontProgramFactory.CreateFont("NotoSansJP-Medium.otf");
    fontProvider.AddFont(fontProgram);
    ConverterProperties properties = new ConverterProperties();
    FontProvider fontProvider = new DefaultFontProvider(true, true, true);
    properties.SetFontProvider(fontProvider);
    HtmlConverter.ConvertToPdf(new FileStream("HTML/input_html.html", FileMode.Open, FileAccess.Read), new FileStream("output_file.pdf", FileMode.Create), properties);
}
