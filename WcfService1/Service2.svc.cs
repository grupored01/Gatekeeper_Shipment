using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Data;

namespace WcfService1
{
  /*  [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]*/
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service2 : IService2
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        

        public bool Ping()
        {
            return true;
        }

        public Shipment GetShipment(string shipmentID)
        {
            var files = Directory.GetFiles(@"C:\eAdapterOutbound", "*.xml");
            Shipment shipment = new Shipment();

            foreach (var file in files)
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(file);
                DataRow dr = dataSet.Tables["DataSource"].Select("Type = 'ForwardingShipment'").First();

                if (dr["Key"].ToString().ToUpper() == shipmentID.ToUpper())
                {
                    shipment.ShipmentID = dr["Key"].ToString();
                    shipment.ConsolID = dataSet.Tables["DataSource"].Select("Type = 'ForwardingConsol'").First()["Key"].ToString();
                    shipment.Transport = dataSet.Tables["TransportMode"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Container = dataSet.Tables["ContainerMode"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Origin = dataSet.Tables["PortOfLoading"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Destination = dataSet.Tables["PortOfDischarge"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Shipper = dataSet.Tables.Contains("Shipper") ? dataSet.Tables["Shipper"].Rows[1]["AccountCode"].ToString() : "";
                    shipment.Consignee = dataSet.Tables.Contains("Consignee") ? dataSet.Tables["Consignee"].Rows[1]["AccountCode"].ToString() : "";
                    shipment.HouseBillNumber = dataSet.Tables["SubShipment"].Rows[0]["WayBillNumber"].ToString();
                    shipment.ETD = Convert.ToDateTime(dataSet.Tables["Date"].Select("Type = 'Departure'").First()["Value"]);
                    shipment.ETA = Convert.ToDateTime(dataSet.Tables["Date"].Select("Type = 'Arrival'").First()["Value"]);
                    shipment.GoodsDescription = dataSet.Tables["SubShipment"].Rows[0]["GoodsDescription"].ToString();
                    shipment.Weight = dataSet.Tables["SubShipment"].Rows[0]["TotalWeight"].ToString();
                    shipment.UW = dataSet.Tables["TotalWeightUnit"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Inners = dataSet.Tables["SubShipment"].Rows[0]["TotalNoOfPacks"].ToString();
                    shipment.TypeI = dataSet.Tables["TotalNoOfPacksPackageType"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                }

            }

            return shipment;
            //  return (new JavaScriptSerializer()).Serialize(publicationTable);
        }

        public Shipment GetShipmentGET(string shipmentID)
        {
            var files = Directory.GetFiles(@"C:\eAdapterOutbound", "*.xml");
            Shipment shipment = new Shipment();

            foreach (var file in files)
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(file);
                DataRow dr = dataSet.Tables["DataSource"].Select("Type = 'ForwardingShipment'").First();

                if (dr["Key"].ToString().ToUpper() == shipmentID.ToUpper())
                { 
                    shipment.ShipmentID = dr["Key"].ToString();
                    shipment.ConsolID = dataSet.Tables["DataSource"].Select("Type = 'ForwardingConsol'").First()["Key"].ToString();
                    shipment.Transport = dataSet.Tables["TransportMode"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Container = dataSet.Tables["ContainerMode"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Origin = dataSet.Tables["PortOfLoading"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Destination = dataSet.Tables["PortOfDischarge"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Shipper = dataSet.Tables.Contains("Shipper") ? dataSet.Tables["Shipper"].Rows[1]["AccountCode"].ToString() : "";
                    shipment.Consignee = dataSet.Tables.Contains("Consignee") ? dataSet.Tables["Consignee"].Rows[1]["AccountCode"].ToString() : "";
                    shipment.HouseBillNumber = dataSet.Tables["SubShipment"].Rows[0]["WayBillNumber"].ToString();
                    shipment.ETD = Convert.ToDateTime(dataSet.Tables["Date"].Select("Type = 'Departure'").First()["Value"]);
                    shipment.ETA = Convert.ToDateTime(dataSet.Tables["Date"].Select("Type = 'Arrival'").First()["Value"]);
                    shipment.GoodsDescription = dataSet.Tables["SubShipment"].Rows[0]["GoodsDescription"].ToString();
                    shipment.Weight = dataSet.Tables["SubShipment"].Rows[0]["TotalWeight"].ToString();
                    shipment.UW = dataSet.Tables["TotalWeightUnit"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                    shipment.Inners = dataSet.Tables["SubShipment"].Rows[0]["TotalNoOfPacks"].ToString();
                    shipment.TypeI = dataSet.Tables["TotalNoOfPacksPackageType"].Select("SubShipment_Id = '0'").First()["Code"].ToString();
                }

            }

            return shipment;
            //  return (new JavaScriptSerializer()).Serialize(publicationTable);
        }
        // Add more operations here and mark them with [OperationContract]
    }
}
