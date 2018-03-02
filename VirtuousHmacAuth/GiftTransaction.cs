using System.Collections.Generic;

namespace VirtuousHmacAuth
{
    class GiftTransaction
    {
        /// <summary>
        /// (Optional) The transaction id from the external system posting to Virtuous.
        /// </summary>
        /// <value>
        /// The transaction identifier.
        /// </value>
        /// <remarks>
        /// This value should be unique and if sent again will produce the only validation error you will encounter.
        /// </remarks>
        public string TransactionId { get; set; }

        /// <summary>
        /// (Suggested) The contact.
        /// </summary>
        /// <value>
        /// The contact.
        /// </value>
        public Contact Contact { get; set; }

        /// <summary>
        /// (Suggested) The gift date.
        /// </summary>
        /// <value>
        /// The gift date.
        /// </value>
        /// <remarks>Example: 7/1/2018</remarks>
        public string GiftDate { get; set; }

        /// <summary>
        /// (Suggested) The type of gift.
        /// </summary>
        /// <value>
        /// The type of the gift.
        /// </value>
        /// <remarks>Examples: Cash, Check, Credit, NonCash, Stock, Other</remarks>
        public string GiftType { get; set; }

        /// <summary>
        /// (Suggested) The amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        /// <remarks>Example: 50.00</remarks>
        public string Amount { get; set; }

        /// <summary>
        /// (Optional) Gets or sets the receipt date.
        /// </summary>
        /// <value>
        /// The receipt date.
        /// </value>
        /// <remarks>Example: 7/1/2018</remarks>
        public string ReceiptDate { get; set; }

        /// <summary>
        /// (Optional) The frequency of giving for this gift. Only needed on the first of a series of gifts.
        /// </summary>
        /// <value>
        /// The frequency.
        /// </value>
        /// <remarks>Examples: Monthly, Quaterly, Yearly</remarks>
        public string Frequency { get; set; }

        /// <summary>
        /// (Optional) The batch the gifts will all be attributed with.
        /// </summary>
        /// <value>
        /// The batch.
        /// </value>
        public string Batch { get; set; }

        /// <summary>
        /// (Optional) The notes for this particular gift.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        public string Notes { get; set; }

        /// <summary>
        /// (Optional) The segment.
        /// </summary>
        /// <value>
        /// The segment.
        /// </value>
        public string Segment { get; set; }

        /// <summary>
        /// (Optional) The cash accounting code.
        /// </summary>
        /// <value>
        /// The cash accounting code.
        /// </value>
        public string CashAccountingCode { get; set; }

        /// <summary>
        /// (Optional) The tribute.
        /// </summary>
        /// <value>
        /// The tribute.
        /// </value>
        public string Tribute { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this gift is private.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is private; otherwise, <c>false</c>.
        /// </value>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// (Optional) The virtuous contact individual id. Defaults to null.
        /// </summary>
        /// <value>
        /// The contact individual identifier.
        /// </value>
        public int? ContactIndividualId { get; set; }

        /// <summary>
        /// (Optional) The passthrough contact id. Defaults to null.
        /// </summary>
        /// <value>
        /// The passthrough contact identifier.
        /// </value>
        public int? PassthroughContactId { get; set; }

        /// <summary>
        /// (Optional) The check number.
        /// </summary>
        /// <value>
        /// The check number.
        /// </value>
        public string CheckNumber { get; set; }

        /// <summary>
        /// (Optional) The type of the credit card.
        /// </summary>
        /// <value>
        /// The type of the credit card.
        /// </value>
        public string CreditCardType { get; set; }

        /// <summary>
        /// (Optional) The designations or gift splits applied to projects.
        /// </summary>
        /// <value>
        /// The designations.
        /// </value>
        public List<Designation> Designations { get; set; }

        /// <summary>
        /// (Optional) The premiums for this gift.
        /// </summary>
        /// <value>
        /// The premiums.
        /// </value>
        public List<Premium> Premiums { get; set; }

        /// <summary>
        /// (Optional) The custom fields for this gift.
        /// </summary>
        /// <value>
        /// The custom fields.
        /// </value>
        public Dictionary<string, string> CustomFields { get; set; }
    }

    public class Address
    {
        /// <summary>
        /// (Optional) Gets or sets the address1.
        /// </summary>
        /// <value>
        /// The address1.
        /// </value>
        public string Address1 { get; set; }

        /// <summary>
        /// (Optional) Gets or sets the address2.
        /// </summary>
        /// <value>
        /// The address2.
        /// </value>
        public string Address2 { get; set; }

        /// <summary>
        /// (Optional) Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// (Optional) Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// (Optional) Gets or sets the postal.
        /// </summary>
        /// <value>
        /// The postal.
        /// </value>
        public string Postal { get; set; }

        /// <summary>
        /// (Optional) Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }
    }

    public class Contact
    {
        /// <summary>
        /// (Suggested) The contact id from the external system posting to Virtuous.
        /// </summary>
        /// <value>
        /// The reference identifier.
        /// </value>
        public string ReferenceId { get; set; }

        /// <summary>
        /// (Optional) The Virtuous id for the contact.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int? Id { get; set; }

        /// <summary>
        /// (Optional) Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// (Suggested) Gets or sets the firstname.
        /// </summary>
        /// <value>
        /// The firstname.
        /// </value>
        public string Firstname { get; set; }

        /// <summary>
        /// (Suggested) Gets or sets the lastname.
        /// </summary>
        /// <value>
        /// The lastname.
        /// </value>
        public string Lastname { get; set; }

        /// <summary>
        /// (Suggested) Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// (Optional) Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string Phone { get; set; }

        /// <summary>
        /// (Suggested) Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public Address Address { get; set; }

        /// <summary>
        /// (Optional) A list of tags seperated by semi-colon to apply to the contact.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        public string Tags { get; set; }
    }

    public class Designation
    {
        /// <summary>
        /// (Optional) The Virtuous id for the project.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int? Id { get; set; }

        /// <summary>
        /// (Optional) The project name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// (Suggested) The project code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// (Suggested) The amount designated to the project.
        /// </summary>
        /// <value>
        /// The amount designated.
        /// </value>
        public string AmountDesignated { get; set; }
    }

    public class Premium
    {
        /// <summary>
        /// (Optional) The Virtuous id for the Premium.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int? Id { get; set; }

        /// <summary>
        /// (Optional) The premium name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// (Suggested) The premium code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// (Suggested) The quantity of the premium.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public string Quantity { get; set; }
    }
}
