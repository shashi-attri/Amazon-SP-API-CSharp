/* 
 * Selling Partner API for Direct Fulfillment Orders
 *
 * The Selling Partner API for Direct Fulfillment Orders provides programmatic access to a direct fulfillment vendor's order data.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorDirectFulfillmentOrders
{
    /// <summary>
    /// Shipment details required for the shipment.
    /// </summary>
    [DataContract]
    public partial class ShipmentDetails :  IEquatable<ShipmentDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShipmentDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDetails" /> class.
        /// </summary>
        /// <param name="isPriorityShipment">When true, this is a priority shipment. (required).</param>
        /// <param name="isScheduledDeliveryShipment">When true, this order is part of a scheduled delivery program..</param>
        /// <param name="isPslipRequired">When true, a packing slip is required to be sent to the customer. (required).</param>
        /// <param name="isGift">When true, the order contain a gift. Include the gift message and gift wrap information..</param>
        /// <param name="shipMethod">Ship method to be used for shipping the order. Amazon defines ship method codes indicating the shipping carrier and shipment service level. To see the full list of ship methods in use, including both the code and the friendly name, search the &#39;Help&#39; section on Vendor Central for &#39;ship methods&#39;. (required).</param>
        /// <param name="shipmentDates">shipmentDates (required).</param>
        /// <param name="messageToCustomer">Message to customer for order status. (required).</param>
        public ShipmentDetails(bool? isPriorityShipment = default(bool?), bool? isScheduledDeliveryShipment = default(bool?), bool? isPslipRequired = default(bool?), bool? isGift = default(bool?), string shipMethod = default(string), ShipmentDates shipmentDates = default(ShipmentDates), string messageToCustomer = default(string))
        {
            // to ensure "isPriorityShipment" is required (not null)
            if (isPriorityShipment == null)
            {
                throw new InvalidDataException("isPriorityShipment is a required property for ShipmentDetails and cannot be null");
            }
            else
            {
                this.IsPriorityShipment = isPriorityShipment;
            }
            // to ensure "isPslipRequired" is required (not null)
            if (isPslipRequired == null)
            {
                throw new InvalidDataException("isPslipRequired is a required property for ShipmentDetails and cannot be null");
            }
            else
            {
                this.IsPslipRequired = isPslipRequired;
            }
            // to ensure "shipMethod" is required (not null)
            if (shipMethod == null)
            {
                throw new InvalidDataException("shipMethod is a required property for ShipmentDetails and cannot be null");
            }
            else
            {
                this.ShipMethod = shipMethod;
            }
            // to ensure "shipmentDates" is required (not null)
            if (shipmentDates == null)
            {
                throw new InvalidDataException("shipmentDates is a required property for ShipmentDetails and cannot be null");
            }
            else
            {
                this.ShipmentDates = shipmentDates;
            }
            // to ensure "messageToCustomer" is required (not null)
            if (messageToCustomer == null)
            {
                throw new InvalidDataException("messageToCustomer is a required property for ShipmentDetails and cannot be null");
            }
            else
            {
                this.MessageToCustomer = messageToCustomer;
            }
            this.IsScheduledDeliveryShipment = isScheduledDeliveryShipment;
            this.IsGift = isGift;
        }
        
        /// <summary>
        /// When true, this is a priority shipment.
        /// </summary>
        /// <value>When true, this is a priority shipment.</value>
        [DataMember(Name="isPriorityShipment", EmitDefaultValue=false)]
        public bool? IsPriorityShipment { get; set; }

        /// <summary>
        /// When true, this order is part of a scheduled delivery program.
        /// </summary>
        /// <value>When true, this order is part of a scheduled delivery program.</value>
        [DataMember(Name="isScheduledDeliveryShipment", EmitDefaultValue=false)]
        public bool? IsScheduledDeliveryShipment { get; set; }

        /// <summary>
        /// When true, a packing slip is required to be sent to the customer.
        /// </summary>
        /// <value>When true, a packing slip is required to be sent to the customer.</value>
        [DataMember(Name="isPslipRequired", EmitDefaultValue=false)]
        public bool? IsPslipRequired { get; set; }

        /// <summary>
        /// When true, the order contain a gift. Include the gift message and gift wrap information.
        /// </summary>
        /// <value>When true, the order contain a gift. Include the gift message and gift wrap information.</value>
        [DataMember(Name="isGift", EmitDefaultValue=false)]
        public bool? IsGift { get; set; }

        /// <summary>
        /// Ship method to be used for shipping the order. Amazon defines ship method codes indicating the shipping carrier and shipment service level. To see the full list of ship methods in use, including both the code and the friendly name, search the &#39;Help&#39; section on Vendor Central for &#39;ship methods&#39;.
        /// </summary>
        /// <value>Ship method to be used for shipping the order. Amazon defines ship method codes indicating the shipping carrier and shipment service level. To see the full list of ship methods in use, including both the code and the friendly name, search the &#39;Help&#39; section on Vendor Central for &#39;ship methods&#39;.</value>
        [DataMember(Name="shipMethod", EmitDefaultValue=false)]
        public string ShipMethod { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentDates
        /// </summary>
        [DataMember(Name="shipmentDates", EmitDefaultValue=false)]
        public ShipmentDates ShipmentDates { get; set; }

        /// <summary>
        /// Message to customer for order status.
        /// </summary>
        /// <value>Message to customer for order status.</value>
        [DataMember(Name="messageToCustomer", EmitDefaultValue=false)]
        public string MessageToCustomer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentDetails {\n");
            sb.Append("  IsPriorityShipment: ").Append(IsPriorityShipment).Append("\n");
            sb.Append("  IsScheduledDeliveryShipment: ").Append(IsScheduledDeliveryShipment).Append("\n");
            sb.Append("  IsPslipRequired: ").Append(IsPslipRequired).Append("\n");
            sb.Append("  IsGift: ").Append(IsGift).Append("\n");
            sb.Append("  ShipMethod: ").Append(ShipMethod).Append("\n");
            sb.Append("  ShipmentDates: ").Append(ShipmentDates).Append("\n");
            sb.Append("  MessageToCustomer: ").Append(MessageToCustomer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShipmentDetails);
        }

        /// <summary>
        /// Returns true if ShipmentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsPriorityShipment == input.IsPriorityShipment ||
                    (this.IsPriorityShipment != null &&
                    this.IsPriorityShipment.Equals(input.IsPriorityShipment))
                ) && 
                (
                    this.IsScheduledDeliveryShipment == input.IsScheduledDeliveryShipment ||
                    (this.IsScheduledDeliveryShipment != null &&
                    this.IsScheduledDeliveryShipment.Equals(input.IsScheduledDeliveryShipment))
                ) && 
                (
                    this.IsPslipRequired == input.IsPslipRequired ||
                    (this.IsPslipRequired != null &&
                    this.IsPslipRequired.Equals(input.IsPslipRequired))
                ) && 
                (
                    this.IsGift == input.IsGift ||
                    (this.IsGift != null &&
                    this.IsGift.Equals(input.IsGift))
                ) && 
                (
                    this.ShipMethod == input.ShipMethod ||
                    (this.ShipMethod != null &&
                    this.ShipMethod.Equals(input.ShipMethod))
                ) && 
                (
                    this.ShipmentDates == input.ShipmentDates ||
                    (this.ShipmentDates != null &&
                    this.ShipmentDates.Equals(input.ShipmentDates))
                ) && 
                (
                    this.MessageToCustomer == input.MessageToCustomer ||
                    (this.MessageToCustomer != null &&
                    this.MessageToCustomer.Equals(input.MessageToCustomer))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IsPriorityShipment != null)
                    hashCode = hashCode * 59 + this.IsPriorityShipment.GetHashCode();
                if (this.IsScheduledDeliveryShipment != null)
                    hashCode = hashCode * 59 + this.IsScheduledDeliveryShipment.GetHashCode();
                if (this.IsPslipRequired != null)
                    hashCode = hashCode * 59 + this.IsPslipRequired.GetHashCode();
                if (this.IsGift != null)
                    hashCode = hashCode * 59 + this.IsGift.GetHashCode();
                if (this.ShipMethod != null)
                    hashCode = hashCode * 59 + this.ShipMethod.GetHashCode();
                if (this.ShipmentDates != null)
                    hashCode = hashCode * 59 + this.ShipmentDates.GetHashCode();
                if (this.MessageToCustomer != null)
                    hashCode = hashCode * 59 + this.MessageToCustomer.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}