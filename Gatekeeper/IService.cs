﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

namespace Gatekeeper
{    
    [ServiceContract]
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceKnownType(typeof(Shipment))]

    public interface IService
    {
        [OperationContract] 
        bool Ping();

        [OperationContract]
      
        Shipment GetShipment(string shipmentID);
    }    

    [DataContract]
    
    public class Shipment
    {
        private string _ShipmentID = string.Empty;
        private string _ConsolID = string.Empty;
        private string _Transport = string.Empty;
        private string _Container = string.Empty;
        private string _Origin = string.Empty;
        private string _Destination = string.Empty;
        private string _Shipper = string.Empty;
        private string _Consignee = string.Empty;
        private string _HouseBillNumber = string.Empty;
        private string _MasterBill = string.Empty;
        private string _Screening = string.Empty;
        private DateTime _ETD;
        private DateTime _ETA;
        private string _Vessel = string.Empty;
        private string _Voyage = string.Empty;
        private string _GoodsDescription  = string.Empty;
        private string _Weight = string.Empty;
        private string _UW = string.Empty;
        private decimal _Volume = 0;
        private string _UV = string.Empty;
        private decimal _Chargeable = 0;
        private string _Unit = string.Empty;
        private string _Inners = string.Empty;
        private string _TypeI = string.Empty;
        private decimal _Packs = 0;
        private string _TypeP = string.Empty;
        private string _NotifyParty = string.Empty;
        private DateTime _IssueDate;
        private string _InterimRcpt = string.Empty;
        private string _EntryNumber = string.Empty;
        private string _EntryType = string.Empty;
        private string _CRLStatusDesc = string.Empty;
        private string _ENSStatusDesc = string.Empty;
        private string _CustomsBroker = string.Empty;
        private DateTime _CustomsAuthDate;


        [DataMember]
        public string ShipmentID
        {
            get { return _ShipmentID; }
            set { _ShipmentID = value; }
        }

        [DataMember]
        public string ConsolID
        {
            get { return _ConsolID; }
            set { _ConsolID = value; }
        }

        [DataMember]
        public string Transport
        {
            get { return _Transport; }
            set { _Transport = value; }
        }

        [DataMember]
        public string Container
        {
            get { return _Container; }
            set { _Container = value; }
        }

        [DataMember]
        public string Origin
        {
            get { return _Origin; }
            set { _Origin = value; }
        }

        [DataMember]
        public string Destination
        {
            get { return _Destination; }
            set { _Destination = value; }
        }

        [DataMember]
        public string Shipper
        {
            get { return _Shipper; }
            set { _Shipper = value; }
        }

        [DataMember]
        public string Consignee
        {
            get { return _Consignee; }
            set { _Consignee = value; }
        }

        [DataMember]
        public string HouseBillNumber
        {
            get { return _HouseBillNumber; }
            set { _HouseBillNumber = value; }
        }

        [DataMember]
        public string MasterBill
        {
            get { return _MasterBill; }
            set { _MasterBill = value; }
        }

        [DataMember]
        public string Screening
        {
            get { return _Screening; }
            set { _Screening = value; }
        }

        [DataMember]
        public DateTime ETD
        {
            get { return _ETD; }
            set { _ETD = value; }
        }

        [DataMember]
        public DateTime ETA
        {
            get { return _ETA; }
            set { _ETA = value; }
        }

        [DataMember]
        public string Vessel
        {
            get { return _Vessel; }
            set { _Vessel = value; }
        }

        [DataMember]
        public string Voyage
        {
            get { return _Voyage; }
            set { _Voyage = value; }
        }

        [DataMember]
        public string GoodsDescription
        {
            get { return _GoodsDescription; }
            set { _GoodsDescription = value; }
        }

        [DataMember]
        public string Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        [DataMember]
        public string UW
        {
            get { return _UW; }
            set { _UW = value; }
        }

        [DataMember]
        public decimal Volume
        {
            get { return _Volume; }
            set { _Volume = value; }
        }

        [DataMember]
        public string UV
        {
            get { return _UV; }
            set { _UV = value; }
        }

        [DataMember]
        public decimal Chargeable
        {
            get { return _Chargeable; }
            set { _Chargeable = value; }
        }

        [DataMember]
        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        [DataMember]
        public string Inners
        {
            get { return _Inners; }
            set { _Inners = value; }
        }

        [DataMember]
        public string TypeI
        {
            get { return _TypeI; }
            set { _TypeI = value; }
        }

        [DataMember]
        public decimal Packs
        {
            get { return _Packs; }
            set { _Packs = value; }
        }

        [DataMember]
        public string TypeP
        {
            get { return _TypeP; }
            set { _TypeP = value; }
        }

        [DataMember]
        public string NotifyParty
        {
            get { return _NotifyParty; }
            set { _NotifyParty = value; }
        }

        [DataMember]
        public DateTime IssueDate
        {
            get { return _IssueDate; }
            set { _IssueDate = value; }
        }

        [DataMember]
        public string InterimRcpt
        {
            get { return _InterimRcpt; }
            set { _InterimRcpt = value; }
        }

        [DataMember]
        public string EntryNumber
        {
            get { return _EntryNumber; }
            set { _EntryNumber = value; }
        }

        [DataMember]
        public string EntryType
        {
            get { return _EntryType; }
            set { _EntryType = value; }
        }

        [DataMember]
        public string CRLStatusDesc
        {
            get { return _CRLStatusDesc; }
            set { _CRLStatusDesc = value; }
        }

        [DataMember]
        public string ENSStatusDesc
        {
            get { return _ENSStatusDesc; }
            set { _ENSStatusDesc = value; }
        }

        [DataMember]
        public string CustomsBroker
        {
            get { return _CustomsBroker; }
            set { _CustomsBroker = value; }
        }

        [DataMember]
        public DateTime CustomsAuthDate
        {
            get { return _CustomsAuthDate; }
            set { _CustomsAuthDate = value; }
        }
    }
}
