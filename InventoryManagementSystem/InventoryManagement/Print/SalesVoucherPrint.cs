using InventoryManagement.Salesman.Activity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace InventoryManagement.Print
{
    internal static class SalesVoucherPrint
    {
        internal static void GenerateThermalReceiptPDF(string invoiceNo, List<CartItem> items, decimal total, decimal received, decimal returned)
        {
            string fileName = $"D:\\Thermal_Receipt_{invoiceNo}.pdf";

            // Height dynamically
            float baseHeight = 350f;
            float rowHeight = 18f;
            float totalHeight = baseHeight + (items.Count * rowHeight);

            Rectangle pageSize = new Rectangle(165f, totalHeight);
            Document doc = new Document(pageSize, 10f, 10f, 10f, 10f);

            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create))
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Fonts
                    var monoFont = iTextSharp.text.FontFactory.GetFont("Courier", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    var boldFont = iTextSharp.text.FontFactory.GetFont("Courier", 9, iTextSharp.text.Font.BOLD, BaseColor.BLACK);


                    // Logo (optional)
                    string logoPath = "D:\\C# Project\\InventoryManagementSystem\\InventoryManagement\\Resources\\Shop Logo.jpg";
                    if (File.Exists(logoPath))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                        logo.ScaleToFit(60f, 60f);
                        logo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(logo);
                    }

                    // Header
                    Paragraph header = new Paragraph("MEHEDI MART LTD.\n", boldFont) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(header);
                    Paragraph address = new Paragraph("Bashundhara R/A, Dhaka\n\n", monoFont) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(address);

                    doc.Add(new Paragraph($"Invoice No: {invoiceNo}", monoFont));
                    doc.Add(new Paragraph($"Date: {DateTime.Now:dd-MMM-yyyy hh:mm tt}\n", monoFont));

                    doc.Add(new Paragraph("--------------------------------\n", monoFont));
                    doc.Add(new Paragraph("Item         Qty  Price   Total", monoFont));
                    doc.Add(new Paragraph("--------------------------------", monoFont));

                    //  Items
                    foreach (var item in items)
                    {
                        string line = item.ProductName.PadRight(12).Substring(0, 12) + " " +
                                      item.Quantity.ToString().PadLeft(3) + " " +
                                      item.MRP.ToString("0.00").PadLeft(6) + " " +
                                      item.Cost.ToString("0.00").PadLeft(7);
                        doc.Add(new Paragraph(line, monoFont));
                    }

                    doc.Add(new Paragraph("--------------------------------", monoFont));
                    doc.Add(new Paragraph($"Subtotal:         {total,10:0.00}", monoFont));
                    doc.Add(new Paragraph($"Received:         {received,10:0.00}", monoFont));
                    doc.Add(new Paragraph($"Return:           {returned,10:0.00}\n", monoFont));

                    // QR Code
                    string qrText = $"Invoice: {invoiceNo}\nTotal: {total:0.00}";
                    var qrWriter = new BarcodeWriter();
                    qrWriter.Format = BarcodeFormat.QR_CODE;
                    var qrBitmap = qrWriter.Write(qrText);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        qrBitmap.Save(ms, ImageFormat.Png);
                        iTextSharp.text.Image qrImage = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        qrImage.ScaleToFit(80f, 80f);
                        qrImage.Alignment = Element.ALIGN_CENTER;
                        doc.Add(qrImage);
                    }

                    // Footer
                    Paragraph footer = new Paragraph("Thank you!\nVisit Again!\n\nPhone: 01713-386933", boldFont) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(footer);

                    doc.Close();
                }

                MessageBox.Show($"🧾 Thermal-style PDF with QR saved:\n{fileName}", "Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ PDF generation failed:\n" + ex.Message);
            }
        }

        internal static void GenerateVoucherPDF(string invoiceNo, List<CartItem> items, decimal total, decimal discount, decimal grandTotal, decimal received, decimal returned)
        {
            string fileName = $"D:\\Voucher_{invoiceNo}.pdf";
            Document doc = new Document(PageSize.A4, 20, 20, 30, 30);

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                doc.Open();

                var shopFont = iTextSharp.text.FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                var addressFont = iTextSharp.text.FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL, new BaseColor(80, 80, 80));
                var headingFont = iTextSharp.text.FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, new BaseColor(0, 102, 204));
                var tableHeaderFont = iTextSharp.text.FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                var tableRowFont = iTextSharp.text.FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                var normalFont = iTextSharp.text.FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL);


                // Header
                Paragraph shopName = new Paragraph("Mehedi Mart Ltd.", shopFont);
                shopName.Alignment = Element.ALIGN_CENTER;
                doc.Add(shopName);

                Paragraph address = new Paragraph("Address: Bashudhara R/A, Dhaka", addressFont);
                address.Alignment = Element.ALIGN_CENTER;
                doc.Add(address);

                doc.Add(new Paragraph("\n"));
                Paragraph heading = new Paragraph("Sales Voucher", headingFont);
                heading.Alignment = Element.ALIGN_CENTER;
                doc.Add(heading);
                doc.Add(new Paragraph($"\nInvoice No: {invoiceNo}", normalFont));
                doc.Add(new Paragraph($"Date: {DateTime.Now:dd MMM yyyy, hh:mm tt}", normalFont));
                doc.Add(new Paragraph("\n"));

                // Table
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 1.5f, 3f, 1f, 1f, 1f });

                string[] headers = { "Code", "Product Name", "Qty", "Unit Price", "Total" };
                foreach (var header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, tableHeaderFont));
                    cell.BackgroundColor = new BaseColor(0, 102, 204); // Deep blue
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 5;
                    table.AddCell(cell);
                }

                foreach (var item in items)
                {
                    table.AddCell(new PdfPCell(new Phrase(item.ProductID, tableRowFont)));
                    table.AddCell(new PdfPCell(new Phrase(item.ProductName, tableRowFont)));
                    table.AddCell(new PdfPCell(new Phrase(item.Quantity.ToString(), tableRowFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(item.MRP.ToString("N2"), tableRowFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                    table.AddCell(new PdfPCell(new Phrase(item.Cost.ToString("N2"), tableRowFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                }

                doc.Add(table);
                doc.Add(new Paragraph("\n"));

                // Totals Summary
                PdfPTable summary = new PdfPTable(2);
                summary.WidthPercentage = 40;
                summary.HorizontalAlignment = Element.ALIGN_RIGHT;

                void AddSummaryRow(string label, decimal value)
                {
                    summary.AddCell(new PdfPCell(new Phrase(label, normalFont)) { Border = 0 });
                    summary.AddCell(new PdfPCell(new Phrase(value.ToString("N2"), normalFont)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });
                }

                AddSummaryRow("Subtotal:", total);
                AddSummaryRow("Discount: ", discount);
                AddSummaryRow("Grand Total: ", grandTotal);
                AddSummaryRow("Received:", received);
                AddSummaryRow("Return:", returned);

                doc.Add(summary);

                // Footer
                doc.Add(new Paragraph("\n\nThank you for shopping with us!", headingFont));
                Paragraph footer = new Paragraph("For any query, call: 01713386933", addressFont);
                footer.Alignment = Element.ALIGN_CENTER;
                doc.Add(footer);

                doc.Close();

                MessageBox.Show($" PDF Voucher saved to:\n{fileName}", "Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate PDF:\n" + ex.Message);
            }
        }
    }
}
