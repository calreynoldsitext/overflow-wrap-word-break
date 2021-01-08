public static void main(String args[]) throws IOException {
    FontProgram fontProgram = FontProgramFactory.createFont("NotoSansJP-Medium.otf");
    fontProvider.addFont(fontProgram);
    ConverterProperties properties = new ConverterProperties();
    FontProvider fontProvider = new DefaultFontProvider(true, true, true);
    properties.setFontProvider(fontProvider);
    HtmlConverter.convertToPdf(new FileInputStream("HTML/target-counter.html"), new FileOutputStream("output_file.pdf"), properties);
}
