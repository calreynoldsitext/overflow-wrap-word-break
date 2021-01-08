public virtual void ConvertHTMLtoPDF() {
    FontProvider fontProvider = new FontProvider();
    FontProgram fontProgram = FontProgramFactory.CreateFont("NotoSansJP-Medium.otf");
    fontProvider.AddFont(fontProgram);
    ConverterProperties properties = new ConverterProperties();
    FontProvider fontProvider = new DefaultFontProvider(true, true, true);
    properties.SetFontProvider(fontProvider);
    HtmlConverter.ConvertToPdf(new FileInputStream("HTML/target-counter.html"), new FileOutputStream("output_file.pdf"), properties);
}
