public void convertHTMLtoPDF() throws IOException {
    ConverterProperties properties = new ConverterProperties();
    FontProvider fontProvider = new DefaultFontProvider(true, true, true);
    properties.setFontProvider(fontProvider);
    HtmlConverter.convertToPdf(new FileInputStream("HTML/input_html.html"), new FileOutputStream("output_file.pdf"), properties);
}
