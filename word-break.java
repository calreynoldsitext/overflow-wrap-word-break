public void convertHTMLtoPDF() throws IOException {
    FontProvider fontProvider = new FontProvider();
    FontProgram fontProgram = FontProgramFactory.createFont("NotoSansJP-Medium.otf");
    fontProvider.addFont(fontProgram);
    ConverterProperties properties = new ConverterProperties();
    FontProvider fontProvider = new DefaultFontProvider(true, true, true);
    properties.setFontProvider(fontProvider);
    HtmlConverter.convertToPdf(new FileInputStream("HTML/input_html.html"), new FileOutputStream("output_file.pdf"), properties);
}
