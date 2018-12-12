using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace CsvToXmlParser
{
       class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo d = new DirectoryInfo("2017");   //(@"C:\Users\taago\Documents\Praktikalt\2017");
            //DirectoryInfo dir = new DirectoryInfo(@"\\psldiskstation\PSLCustomerRelations\MMA\Bloomberg.Deal\Bloomberg.Deal1");
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\taago\Documents\Praktikalt\2017");



            FileInfo[] infos = dir.GetFiles();

          
            foreach (FileInfo f in infos)
                using (TextFieldParser parser = new TextFieldParser(f.FullName))
                {
                    parser.HasFieldsEnclosedInQuotes = true;

                    string[] source = File.ReadAllLines(f.FullName);
                    string[] separatingChars = new string[] { "\"\"", "," };

                    XElement deal = new XElement("TradeConfirmation",
                        from str in source
                        let fields = str.Split(separatingChars, StringSplitOptions.None)
                        select new XElement("trade",
                            new XElement("Deal", fields[0]),
                            new XElement("DealType", fields[1]),
                            new XElement("Side", fields[2]),
                            new XElement("Product", fields[3]),
                            //new XElement("SourceReference", fields[4]),
                            new XElement("Status", fields[5]),
                            new XElement("ReviseVer", fields[6]),
                            new XElement("TradeID", fields[7]),
                            new XElement("BlockID", fields[8]),
                            new XElement("TraderID", fields[9]),
                            new XElement("TraderName", fields[10]),
                            new XElement("CounterpartyUUID", fields[11]),
                            new XElement("CounterpartyName", fields[12]),
                            new XElement("DateOfDeal", fields[13]),
                            new XElement("TimeOfDeal", fields[14]),
                            new XElement("TradeDate", fields[15]),
                            new XElement("DateConfirmed", fields[16]),
                            new XElement("TimeConfirmed", fields[17]),
                            new XElement("Bank1DealingCode", fields[18]),
                            new XElement("Bank1Name", fields[19]),
                            new XElement("UserIdent1", fields[20]),
                            new XElement("UserIdent2", fields[21]),
                            new XElement("UserIdent3", fields[22]),
                            new XElement("UserIdent4", fields[23]),
                            new XElement("PrimeBrokerDealingCode", fields[24]),
                            new XElement("PrimeBrokerName", fields[25]),
                            new XElement("Currency1", fields[26]),
                            new XElement("Currency2", fields[27]),
                            new XElement("NearAmtDealt", fields[28]),
                            new XElement("NearCcyDealt", fields[29]),
                            new XElement("NearCounterAmt", fields[30]),
                            new XElement("NearCounterCcy", fields[31]),
                            new XElement("FwdPointsNear", fields[32]),
                            new XElement("FarAmtDealt", fields[33]),
                            new XElement("FarCcyDealt", fields[34]),
                            new XElement("FarCounterAmt", fields[35]),
                            new XElement("FarCounterCcy", fields[36]),
                            new XElement("FwdPointsFar", fields[37]),
                            new XElement("SpotBasisRate", fields[38]),
                            new XElement("DepositRate", fields[39]),
                            new XElement("DayCountType", fields[40]),
                            new XElement("NewRoll", fields[41]),
                            new XElement("VolumeOfInterest", fields[42]),
                            new XElement("ExchangeRatePeriod1", fields[43]),
                            new XElement("ValueDatePeriod1Currency1", fields[44]),
                            new XElement("TenorPeriod1", fields[45]),
                            new XElement("FixingDatePeriod1", fields[46]),
                            new XElement("FixingSourcePeriod1", fields[47]),
                            new XElement("SettleCrncy", fields[48]),
                            new XElement("SwapRate", fields[49]),
                            new XElement("ExchangeRatePeriod2", fields[50]),
                            new XElement("ValueDatePeriod2Currency1", fields[51]),
                            new XElement("TenorPeriod2", fields[52]),
                            new XElement("FixingDatePeriod2", fields[53]),
                            new XElement("FixingSourcePeriod2", fields[54]),
                            new XElement("SplitTenorCcy1", fields[55]),
                            new XElement("SplitValueDateCcy1", fields[56]),
                            new XElement("SplitTenorCCy2", fields[57]),
                            new XElement("SplitValueDateCcy2", fields[58]),
                            new XElement("CommentText", fields[59]),
                            new XElement("NoteName1", fields[60]),
                            new XElement("NoteText1", fields[61]),
                            new XElement("NoteName2", fields[62]),
                            new XElement("NoteText2", fields[63]),
                            new XElement("NoteName3", fields[64]),
                            new XElement("NoteText3", fields[65]),
                            new XElement("NoteName4", fields[66]),
                            new XElement("NoteText4", fields[67]),
                            new XElement("NoteName5", fields[68]),
                            new XElement("NoteText5", fields[69]),
                            new XElement("CompQuote1", fields[70]),
                            new XElement("CompDC1", fields[71]),
                            new XElement("CompQuote2", fields[72]),
                            new XElement("CompDC2", fields[73]),
                            new XElement("CompQuote3", fields[74]),
                            new XElement("CompDC3", fields[75]),
                            new XElement("CompQuote4", fields[76]),
                            new XElement("CompDC4", fields[77]),
                            new XElement("CompQuote5", fields[78]),
                            new XElement("CompDC5", fields[79]),
                            new XElement("Portfolio", fields[80]),
                            new XElement("AlocAccount", fields[81]),
                            new XElement("AlocDescription", fields[82]),
                            new XElement("AlocCustodian", fields[83]),
                            new XElement("AllocPrimeBrokerName", fields[84]),
                            new XElement("RefSpotRate", fields[85]),
                            new XElement("RefRatePeriod1", fields[86]),
                            new XElement("RefRatePeriod2", fields[87]),
                            new XElement("PayCcy", fields[88]),
                            new XElement("PaySWIFT", fields[89]),
                            new XElement("PayAccount", fields[90]),
                            new XElement("PayBank", fields[91]),
                            new XElement("PayBranch", fields[92]),
                            new XElement("PayBeneficiary", fields[93]),
                            new XElement("PaySpecInstr", fields[94]),
                            new XElement("RecCcy", fields[95]),
                            new XElement("RecSWIFT", fields[96]),
                            new XElement("RecAccount", fields[97]),
                            new XElement("RecBank", fields[98]),
                            new XElement("RecBranch", fields[99]),
                            new XElement("RecBeneficiary", fields[100]),
                            new XElement("RecSpecInstr", fields[101]),
                            new XElement("SpotRateMid", fields[102]),
                            new XElement("AllinNearMid", fields[103]),
                            new XElement("NearFwdMid", fields[104]),
                            new XElement("AllinFarMid", fields[105]),
                            new XElement("FarFwdPointMid", fields[106]),
                            new XElement("USINamespace", fields[107]),
                            new XElement("USI", fields[108]),
                            new XElement("USINear", fields[109]),
                            new XElement("DeliveryDate", fields[110]),
                            new XElement("BanknoteRateType", fields[111]),
                            new XElement("Comission"),// fields[112]),
                            new XElement("ExecutionVenue"), //fields[113]),
                            new XElement("BrokerUUID"),//fields[114]),
                            new XElement("BrokerDealcode"), //fields[115]),
                            new XElement("GroupID"), //fields[116]),
                            new XElement("GroupType"), //fields[117]),
                            new XElement("TradeMethod"), //fields[118]),
                            new XElement("Subtype"), //fields[119]),
                            new XElement("ExternalRef_ID"), //fields[120]),
                            new XElement("ExecutionVenueLEI"), //fields[121]),
                            new XElement("ISIN"), //fields[122]),
                            new XElement("ISIN2"), //fields[123]),
                            new XElement("ExecWithinFirm_Algo"), //fields[124]),
                            new XElement("ExecWithinFirm_GPI"), //fields[125]),
                            new XElement("ExecWithinFirm_ShortCode"), //fields[126]),
                            new XElement("InvestDecWithinFirm_Algo"), //fields[127]),
                            new XElement("InvestDecWithinFirm_GPI"), //fields[128]),
                            new XElement("InvestDecWithinFirm_ShortCode"), //fields[129]),
                            new XElement("TradingCapacity"), //fields[130]),
                            new XElement("PackageID"), //fields[131]),
                            new XElement("PretradeTransparencyType"), //fields[132]),
                            new XElement("PretradeTransparencyReason"), //fields[133]),
                            new XElement("PosttradeTransparencyType"), //fields[134]),
                            new XElement("PosttradeTransparencyReason"), //fields[135]),
                            new XElement("CommoditiesDIndicator"), //fields[136]),
                            new XElement("SecuritiesFinancingTransaction"), //fields[137]),
                            new XElement("ClientIdentificationCode"), //fields[138]),
                            new XElement("OrdRegTimestamp"), //fields[139]),
                            new XElement("OrdRegTimestampType"), //fields[140]),
                            new XElement("TrdRegTimestamp"), //fields[141]),
                            new XElement("TrdRegTimestampType"), //fields[142]),
                            new XElement("CountryofMembership") //fields[143])
                            ),
                            new XElement("allocations")
                    );
                    XDocument result = new XDocument(deal);
                    result.Save(f.FullName.Replace(".csv", ".xml").Replace("DEAL", "XMLDEAL"));
                }

            try
            {
                dir.CreateSubdirectory("XMLDEALs");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        //string sourceDirectory = @"\\psldiskstation\PSLCustomerRelations\MMA\Bloomberg.Deal\Bloomberg.Deal1";
        
            string sourceDirectory = dir.FullName;
            //string archiveDirectory = @"\\psldiskstation\PSLCustomerRelations\MMA\Bloomberg.Deal\Bloomberg.Deal1\XMLDEALs";
            string archiveDirectory = @"C:\Users\taago\Documents\Praktikalt\2017\XMLDEALs";
            try
            {
                var xmlFiles = Directory.EnumerateFiles(sourceDirectory, "*.xml");

                foreach (string currentFile in xmlFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

           
            //DirectoryInfo d = new DirectoryInfo(@"C:\Users\taago\Documents\Praktikalt\2017");
            //FileInfo[] csvfiles = dir.GetFiles("*.csv");
            //Console.WriteLine("Total number of csv files " + csvfiles.Length);
            //Console.WriteLine();
            //foreach (FileInfo f in infos)
            //{
            //    Console.WriteLine("Name is : {0}", f.Name);
            //    //Console.WriteLine("Name is : {0}", f.FullName);
            //    Console.WriteLine("Length of the file is : {0}", f.Length);
            //    Console.WriteLine("Creation time is : {0}", f.CreationTime);
            //    Console.WriteLine("Attributes of the file are : {0}",
            //                       f.Attributes.ToString());
            //}
            
            //FileInfo fi = new FileInfo(@"\\psldiskstation\PSLCustomerRelations\MMA\Bloomberg.Deal\Bloomberg.Deal1\Log.txt");                
            //StreamWriter w = fi.CreateText();
            //w.WriteLine("Creation Time: {0}", fi.CreationTime);
            //w.WriteLine("Full Name: {0}", fi.FullName);
            //w.WriteLine("FileAttributes: {0}", fi.Attributes.ToString());
            //w.WriteLine("Total .csv Files converted to .xml: " + fi.Length);
            //w.Write(w.NewLine);
            //w.WriteLine("Thanks for your time");
            //w.Close();
                       
            //Console.WriteLine("Press any key to delete the file");
            //Console.Read();
            //fstr.Close();
            //fi.Delete();

            //Console.WriteLine();
            //Console.WriteLine("tehtud " + fi.Length + " Xml faili" );
            //Debug.Print("Files renamed " + fi.Length);
        }
    }
}
