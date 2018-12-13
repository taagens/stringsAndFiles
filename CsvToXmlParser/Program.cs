using System;
using System.Collections.Generic;
using System.Data;
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
            //DirectoryInfo dir = new DirectoryInfo("2017");   //(@"C:\Users\taago\Documents\Praktikalt\2017");
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\taago\Documents\Praktikalt\2017");
            //DirectoryInfo dir = new DirectoryInfo(@"\\psldiskstation\PSLCustomerRelations\MMA\Bloomberg.Deal\Bloomberg.Deal5");
            //DirectoryInfo dir = new DirectoryInfo(@"\\psldiskstation\PSLCustomerRelations\MMA\Bloomberg.Deal\Bloomberg.Deal4\MMA.Bloomberg.Deals.Full");


            FileInfo[] infos = dir.GetFiles();

            string newPath = Path.Combine(dir.FullName, "XML");
            Directory.CreateDirectory(newPath);

            foreach (FileInfo f in infos)
            {
                DataTable dt = exst.LoadCSV(f.FullName);
                
                DataSet dataSetCSV = new DataSet("TradeConfirmation");
                dt.TableName = "trade";
                dataSetCSV.Tables.Add(dt);
                dt.Columns[0].ColumnName = "Deal";
                dt.Columns[1].ColumnName = "DealType";
                dt.Columns[2].ColumnName = "Side";
                dt.Columns[3].ColumnName = "Product";
                //dt.Columns[4].ColumnName = "SourceReference";
                dt.Columns[5].ColumnName = "Status";
                dt.Columns[6].ColumnName = "ReviseVer";
                dt.Columns[7].ColumnName = "TradeID";
                dt.Columns[8].ColumnName = "BlockID";
                dt.Columns[9].ColumnName = "TraderID";
                dt.Columns[10].ColumnName = "TraderName";
                dt.Columns[11].ColumnName = "CounterpartyUUID";
                dt.Columns[12].ColumnName = "CounterpartyName";
                dt.Columns[13].ColumnName = "DateOfDeal";
                dt.Columns[14].ColumnName = "TimeOfDeal";
                dt.Columns[15].ColumnName = "TradeDate";
                dt.Columns[16].ColumnName = "DateConfirmed";
                dt.Columns[17].ColumnName = "TimeConfirmed";
                dt.Columns[18].ColumnName = "Bank1DealingCode";
                dt.Columns[19].ColumnName = "Bank1Name";
                dt.Columns[20].ColumnName = "UserIdent1";
                dt.Columns[21].ColumnName = "UserIdent2";
                dt.Columns[22].ColumnName = "UserIdent3";
                dt.Columns[23].ColumnName = "UserIdent4";
                dt.Columns[24].ColumnName = "PrimeBrokerDealingCode";
                dt.Columns[25].ColumnName = "PrimeBrokerName";
                dt.Columns[26].ColumnName = "Currency1";
                dt.Columns[27].ColumnName = "Currency2";
                dt.Columns[28].ColumnName = "NearAmtDealt";
                dt.Columns[29].ColumnName = "NearCcyDealt";
                dt.Columns[30].ColumnName = "NearCounterAmt";
                dt.Columns[31].ColumnName = "NearCounterCcy";
                dt.Columns[32].ColumnName = "FwdPointsNear";
                dt.Columns[33].ColumnName = "FarAmtDealt";
                dt.Columns[34].ColumnName = "FarCcyDealt";
                dt.Columns[35].ColumnName = "FarCounterAmt";
                dt.Columns[36].ColumnName = "FarCounterCcy";
                dt.Columns[37].ColumnName = "FwdPointsFar";
                dt.Columns[38].ColumnName = "SpotBasisRate";
                dt.Columns[39].ColumnName = "DepositRate";
                dt.Columns[40].ColumnName = "DayCountType";
                dt.Columns[41].ColumnName = "NewRoll";
                dt.Columns[42].ColumnName = "VolumeOfInterest";
                dt.Columns[43].ColumnName = "ExchangeRatePeriod1";
                dt.Columns[44].ColumnName = "ValueDatePeriod1Currency1";
                dt.Columns[45].ColumnName = "TenorPeriod1";
                dt.Columns[46].ColumnName = "FixingDatePeriod1";
                dt.Columns[47].ColumnName = "FixingSourcePeriod";
                dt.Columns[48].ColumnName = "SettleCrncy";
                dt.Columns[49].ColumnName = "SwapRate";
                dt.Columns[50].ColumnName = "ExchangeRatePeriod2";
                dt.Columns[51].ColumnName = "ValueDatePeriod2Currency1";
                dt.Columns[52].ColumnName = "TenorPeriod2";
                dt.Columns[53].ColumnName = "FixingDatePeriod2";
                dt.Columns[54].ColumnName = "FixingSourcePeriod2";
                dt.Columns[55].ColumnName = "SplitTenorCcy1";
                dt.Columns[56].ColumnName = "SplitValueDateCcy1";
                dt.Columns[57].ColumnName = "SplitTenorCCy2";
                dt.Columns[58].ColumnName = "SplitValueDateCcy2";
                dt.Columns[59].ColumnName = "CommentText";
                dt.Columns[60].ColumnName = "NoteName1";
                dt.Columns[61].ColumnName = "NoteText1";
                dt.Columns[62].ColumnName = "NoteName2";
                dt.Columns[63].ColumnName = "NoteText2";
                dt.Columns[64].ColumnName = "NoteName3";
                dt.Columns[65].ColumnName = "NoteText3";
                dt.Columns[66].ColumnName = "NoteName4";
                dt.Columns[67].ColumnName = "NoteText4";
                dt.Columns[68].ColumnName = "NoteName5";
                dt.Columns[69].ColumnName = "NoteText5";
                dt.Columns[70].ColumnName = "CompQuote1";
                dt.Columns[71].ColumnName = "CompDC1";
                dt.Columns[72].ColumnName = "CompQuote2";
                dt.Columns[73].ColumnName = "CompDC2";
                dt.Columns[74].ColumnName = "CompQuote3";
                dt.Columns[75].ColumnName = "CompDC3";
                dt.Columns[76].ColumnName = "CompQuote4";
                dt.Columns[77].ColumnName = "CompDC4";
                dt.Columns[78].ColumnName = "CompQuote5";
                dt.Columns[79].ColumnName = "CompDC5";
                dt.Columns[80].ColumnName = "Portfolio";
                dt.Columns[81].ColumnName = "AlocAccount";
                dt.Columns[82].ColumnName = "AlocDescription";
                dt.Columns[83].ColumnName = "AlocCustodian";
                dt.Columns[84].ColumnName = "AllocPrimeBrokerName";
                dt.Columns[85].ColumnName = "RefSpotRate";
                dt.Columns[86].ColumnName = "RefRatePeriod1";
                dt.Columns[87].ColumnName = "RefRatePeriod2";
                dt.Columns[88].ColumnName = "PayCcy";
                dt.Columns[89].ColumnName = "PaySWIFT";
                dt.Columns[90].ColumnName = "PayAccount";
                dt.Columns[91].ColumnName = "PayBank";
                dt.Columns[92].ColumnName = "PayBranch";
                dt.Columns[93].ColumnName = "PayBeneficiary";
                dt.Columns[94].ColumnName = "PaySpecInstr";
                dt.Columns[95].ColumnName = "RecCcy";
                dt.Columns[96].ColumnName = "RecSWIFT";
                dt.Columns[97].ColumnName = "RecAccount";
                dt.Columns[98].ColumnName = "RecBank";
                dt.Columns[99].ColumnName = "RecBranch";
                dt.Columns[100].ColumnName = "RecBeneficiary";
                dt.Columns[101].ColumnName = "RecSpecInstr";
                dt.Columns[102].ColumnName = "SpotRateMid"; 
                dt.Columns[103].ColumnName = "AllinNearMid";
                dt.Columns[104].ColumnName = "NearFwdMid";
                dt.Columns[105].ColumnName = "AllinFarMid";
                dt.Columns[106].ColumnName = "FarFwdPointMid";
                dt.Columns[107].ColumnName = "USINamespace";
                dt.Columns[108].ColumnName = "USI";
                dt.Columns[109].ColumnName = "USINear";
                dt.Columns[110].ColumnName = "DeliveryDate";
                dt.Columns[111].ColumnName = "BanknoteRateType";
                dt.Columns[112].ColumnName = "Comission";
                dt.Columns[113].ColumnName = "ExecutionVenue";
                dt.Columns[114].ColumnName = "BrokerUUID";
                dt.Columns[115].ColumnName = "BrokerDealcode";
                dt.Columns[116].ColumnName = "GroupID";
                dt.Columns[117].ColumnName = "GroupType";
                dt.Columns[118].ColumnName = "TradeMethod";
                dt.Columns[119].ColumnName = "Subtype";
                dt.Columns[120].ColumnName = "ExternalRef_ID";
                dt.Columns[121].ColumnName = "ExecutionVenueLEI";
                dt.Columns[122].ColumnName = "ISIN";
                dt.Columns[123].ColumnName = "ISIN2";
                dt.Columns[124].ColumnName = "ExecWithinFirm_Algo";
                dt.Columns[125].ColumnName = "ExecWithinFirm_GPI";
                dt.Columns[126].ColumnName = "ExecWithinFirm_ShortCode";
                dt.Columns[127].ColumnName = "InvestDecWithinFirm_Algo";
                dt.Columns[128].ColumnName = "InvestDecWithinFirm_GPI";
                dt.Columns[129].ColumnName = "InvestDecWithinFirm_ShortCode";
                dt.Columns[130].ColumnName = "TradingCapacity";
                dt.Columns[131].ColumnName = "PackageID";
                dt.Columns[132].ColumnName = "PretradeTransparencyType";
                dt.Columns[133].ColumnName = "PretradeTransparencyReason";
                dt.Columns[134].ColumnName = "PosttradeTransparencyType";
                dt.Columns[135].ColumnName = "PosttradeTransparencyReason";
                dt.Columns[136].ColumnName = "CommoditiesDIndicator";
                dt.Columns[137].ColumnName = "SecuritiesFinancingTransaction";
                dt.Columns[138].ColumnName = "ClientIdentificationCode";
                dt.Columns[139].ColumnName = "OrdRegTimestamp";
                dt.Columns[140].ColumnName = "OrdRegTimestampType";
                dt.Columns[141].ColumnName = "TrdRegTimestamp";
                dt.Columns[142].ColumnName = "TrdRegTimestampType";
                dt.Columns[143].ColumnName = "CountryofMembership";

                string TimeOfDealChek = dt.Rows[0]["TimeOfDeal"] as string;
                if (TimeOfDealChek?.Length == 5)
                    dt.Rows[0]["TimeOfDeal"] = "0" + TimeOfDealChek;

                string TimeConfirmedChek = dt.Rows[0]["TimeConfirmed"] as string;
                if (TimeConfirmedChek?.Length == 5)
                    dt.Rows[0]["TimeConfirmed"] = "0" + TimeConfirmedChek;

                //DataSet dataSetOriginalXML = new DataSet();
                //dataSetOriginalXML.ReadXml("XMLDEAL20181203_94657_2_17819403T_0_0.xml");
                //dataSetOriginalXML.Tables[0].Columns.RemoveAt(141);
                //dataSetOriginalXML.Tables[0].Columns.RemoveAt(142);
              

                //Debug.Assert(dataSetOriginalXML.GetXml() == dataSetCSV.GetXml(), "Pole ok!");


                File.WriteAllText(Path.Combine(newPath, "XML" + Path.ChangeExtension(Path.GetFileName(f.FullName), ".xml")), dataSetCSV.GetXml());
                               
            
            }
                       
        }
    }
}
