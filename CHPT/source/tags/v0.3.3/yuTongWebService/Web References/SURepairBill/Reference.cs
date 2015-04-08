﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1026
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.1026 版自动生成。
// 
#pragma warning disable 1591

namespace yuTongWebService.SURepairBill {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="repairBillSUBinding", Namespace="http://isg.yutong.com/repairBillSU/")]
    public partial class repairBillSUService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback repairBillSUOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public repairBillSUService() {
            this.Url = "https://isgqas.yutong.com:2222/ISG/ws/invokeService";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event repairBillSUCompletedEventHandler repairBillSUCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://isg.yutong.com/repairBillSU/", ResponseNamespace="http://isg.yutong.com/repairBillSU/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Result", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Result repairBillSU([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string RequestUser, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string RequestTime, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string RequestType, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] repairBill repairBill, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] clientInfo clientInfo) {
            object[] results = this.Invoke("repairBillSU", new object[] {
                        RequestUser,
                        RequestTime,
                        RequestType,
                        repairBill,
                        clientInfo});
            return ((Result)(results[0]));
        }
        
        /// <remarks/>
        public void repairBillSUAsync(string RequestUser, string RequestTime, string RequestType, repairBill repairBill, clientInfo clientInfo) {
            this.repairBillSUAsync(RequestUser, RequestTime, RequestType, repairBill, clientInfo, null);
        }
        
        /// <remarks/>
        public void repairBillSUAsync(string RequestUser, string RequestTime, string RequestType, repairBill repairBill, clientInfo clientInfo, object userState) {
            if ((this.repairBillSUOperationCompleted == null)) {
                this.repairBillSUOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrepairBillSUOperationCompleted);
            }
            this.InvokeAsync("repairBillSU", new object[] {
                        RequestUser,
                        RequestTime,
                        RequestType,
                        repairBill,
                        clientInfo}, this.repairBillSUOperationCompleted, userState);
        }
        
        private void OnrepairBillSUOperationCompleted(object arg) {
            if ((this.repairBillSUCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.repairBillSUCompleted(this, new repairBillSUCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://isg.yutong.com/repairBillSU/")]
    public partial class repairBill {
        
        private string maintain_noField;
        
        private string clearing_timeField;
        
        private string cust_idField;
        
        private string cust_nameField;
        
        private string linkmanField;
        
        private string link_man_mobileField;
        
        private string vehicle_noField;
        
        private string vehicle_modelField;
        
        private string vehicle_brandField;
        
        private string vehicle_vinField;
        
        private string engine_noField;
        
        private string driver_nameField;
        
        private string driver_mobileField;
        
        private string travel_mileageField;
        
        private string maintain_typeField;
        
        private string remarkField;
        
        private string man_hour_sum_moneyField;
        
        private string man_hour_sumField;
        
        private string fitting_sum_moneyField;
        
        private string fitting_sumField;
        
        private string other_item_tax_costField;
        
        private string other_item_sumField;
        
        private string privilege_costField;
        
        private string should_sumField;
        
        private string received_sumField;
        
        private string cost_typesField;
        
        private string sum_moneyField;
        
        private string other_remarksField;
        
        private string dispatch_timeField;
        
        private string start_work_timeField;
        
        private string shut_down_timeField;
        
        private string complete_work_timeField;
        
        private RepairProjectDetail[] repairProjectDetailsField;
        
        private RepairmaterialDetail[] repairmaterialDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string maintain_no {
            get {
                return this.maintain_noField;
            }
            set {
                this.maintain_noField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string clearing_time {
            get {
                return this.clearing_timeField;
            }
            set {
                this.clearing_timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cust_id {
            get {
                return this.cust_idField;
            }
            set {
                this.cust_idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cust_name {
            get {
                return this.cust_nameField;
            }
            set {
                this.cust_nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string linkman {
            get {
                return this.linkmanField;
            }
            set {
                this.linkmanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string link_man_mobile {
            get {
                return this.link_man_mobileField;
            }
            set {
                this.link_man_mobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string vehicle_no {
            get {
                return this.vehicle_noField;
            }
            set {
                this.vehicle_noField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string vehicle_model {
            get {
                return this.vehicle_modelField;
            }
            set {
                this.vehicle_modelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string vehicle_brand {
            get {
                return this.vehicle_brandField;
            }
            set {
                this.vehicle_brandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string vehicle_vin {
            get {
                return this.vehicle_vinField;
            }
            set {
                this.vehicle_vinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string engine_no {
            get {
                return this.engine_noField;
            }
            set {
                this.engine_noField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string driver_name {
            get {
                return this.driver_nameField;
            }
            set {
                this.driver_nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string driver_mobile {
            get {
                return this.driver_mobileField;
            }
            set {
                this.driver_mobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string travel_mileage {
            get {
                return this.travel_mileageField;
            }
            set {
                this.travel_mileageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string maintain_type {
            get {
                return this.maintain_typeField;
            }
            set {
                this.maintain_typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string remark {
            get {
                return this.remarkField;
            }
            set {
                this.remarkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string man_hour_sum_money {
            get {
                return this.man_hour_sum_moneyField;
            }
            set {
                this.man_hour_sum_moneyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string man_hour_sum {
            get {
                return this.man_hour_sumField;
            }
            set {
                this.man_hour_sumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fitting_sum_money {
            get {
                return this.fitting_sum_moneyField;
            }
            set {
                this.fitting_sum_moneyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fitting_sum {
            get {
                return this.fitting_sumField;
            }
            set {
                this.fitting_sumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string other_item_tax_cost {
            get {
                return this.other_item_tax_costField;
            }
            set {
                this.other_item_tax_costField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string other_item_sum {
            get {
                return this.other_item_sumField;
            }
            set {
                this.other_item_sumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string privilege_cost {
            get {
                return this.privilege_costField;
            }
            set {
                this.privilege_costField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string should_sum {
            get {
                return this.should_sumField;
            }
            set {
                this.should_sumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string received_sum {
            get {
                return this.received_sumField;
            }
            set {
                this.received_sumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cost_types {
            get {
                return this.cost_typesField;
            }
            set {
                this.cost_typesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sum_money {
            get {
                return this.sum_moneyField;
            }
            set {
                this.sum_moneyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string other_remarks {
            get {
                return this.other_remarksField;
            }
            set {
                this.other_remarksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string dispatch_time {
            get {
                return this.dispatch_timeField;
            }
            set {
                this.dispatch_timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string start_work_time {
            get {
                return this.start_work_timeField;
            }
            set {
                this.start_work_timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string shut_down_time {
            get {
                return this.shut_down_timeField;
            }
            set {
                this.shut_down_timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string complete_work_time {
            get {
                return this.complete_work_timeField;
            }
            set {
                this.complete_work_timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RepairProjectDetail[] RepairProjectDetails {
            get {
                return this.repairProjectDetailsField;
            }
            set {
                this.repairProjectDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RepairmaterialDetail[] RepairmaterialDetails {
            get {
                return this.repairmaterialDetailsField;
            }
            set {
                this.repairmaterialDetailsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://isg.yutong.com/repairBillSU/")]
    public partial class RepairProjectDetail {
        
        private string item_noField;
        
        private string item_typeField;
        
        private string item_nameField;
        
        private string man_hour_typeField;
        
        private string man_hour_quantityField;
        
        private string man_hour_norm_unitpriceField;
        
        private string sum_money_goodsField;
        
        private string three_warrantyField;
        
        private string item_remarksField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string item_no {
            get {
                return this.item_noField;
            }
            set {
                this.item_noField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string item_type {
            get {
                return this.item_typeField;
            }
            set {
                this.item_typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string item_name {
            get {
                return this.item_nameField;
            }
            set {
                this.item_nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string man_hour_type {
            get {
                return this.man_hour_typeField;
            }
            set {
                this.man_hour_typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string man_hour_quantity {
            get {
                return this.man_hour_quantityField;
            }
            set {
                this.man_hour_quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string man_hour_norm_unitprice {
            get {
                return this.man_hour_norm_unitpriceField;
            }
            set {
                this.man_hour_norm_unitpriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sum_money_goods {
            get {
                return this.sum_money_goodsField;
            }
            set {
                this.sum_money_goodsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string three_warranty {
            get {
                return this.three_warrantyField;
            }
            set {
                this.three_warrantyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string item_remarks {
            get {
                return this.item_remarksField;
            }
            set {
                this.item_remarksField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://isg.yutong.com/repairBillSU/")]
    public partial class Result {
        
        private string stateField;
        
        private string errorMsgField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string errorMsg {
            get {
                return this.errorMsgField;
            }
            set {
                this.errorMsgField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://isg.yutong.com/repairBillSU/")]
    public partial class clientInfo {
        
        private string clientIDField;
        
        private string serviceIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string clientID {
            get {
                return this.clientIDField;
            }
            set {
                this.clientIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serviceID {
            get {
                return this.serviceIDField;
            }
            set {
                this.serviceIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://isg.yutong.com/repairBillSU/")]
    public partial class RepairmaterialDetail {
        
        private string car_parts_codeField;
        
        private string parts_nameField;
        
        private string normsField;
        
        private string unitField;
        
        private string quantityField;
        
        private string unit_priceField;
        
        private string sum_moneyField;
        
        private string vehicle_brandField;
        
        private string three_warrantyField;
        
        private string parts_remarksField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string car_parts_code {
            get {
                return this.car_parts_codeField;
            }
            set {
                this.car_parts_codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string parts_name {
            get {
                return this.parts_nameField;
            }
            set {
                this.parts_nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string norms {
            get {
                return this.normsField;
            }
            set {
                this.normsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string unit_price {
            get {
                return this.unit_priceField;
            }
            set {
                this.unit_priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sum_money {
            get {
                return this.sum_moneyField;
            }
            set {
                this.sum_moneyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string vehicle_brand {
            get {
                return this.vehicle_brandField;
            }
            set {
                this.vehicle_brandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string three_warranty {
            get {
                return this.three_warrantyField;
            }
            set {
                this.three_warrantyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string parts_remarks {
            get {
                return this.parts_remarksField;
            }
            set {
                this.parts_remarksField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void repairBillSUCompletedEventHandler(object sender, repairBillSUCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class repairBillSUCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal repairBillSUCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Result Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Result)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591