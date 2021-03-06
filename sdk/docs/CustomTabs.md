# IO.Swagger.Model.CustomTabs
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Anchor** | **string** | An optional string that is used to auto-match tabs to strings located in the documents of an envelope. | [optional] 
**AnchorCaseSensitive** | **string** | Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**. - -&gt; | [optional] 
**AnchorHorizontalAlignment** | **string** | Reserved for DocuSign. &lt;!- - Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**. - -&gt;  | [optional] 
**AnchorIgnoreIfNotPresent** | **string** | When set to **true**, this tab is ignored if anchorString is not found in the document. | [optional] 
**AnchorMatchWholeWord** | **string** | Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**. - -&gt;  | [optional] 
**AnchorUnits** | **string** | Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches. | [optional] 
**AnchorXOffset** | **string** | Specifies the X axis location of the tab, in achorUnits, relative to the anchorString. | [optional] 
**AnchorYOffset** | **string** | Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString. | [optional] 
**Bold** | **string** | When set to **true**, the information in the tab is bold. | [optional] 
**ConcealValueOnDocument** | **string** | When set to **true**, the field appears normally while the recipient is adding or modifying the information in the field, but the data is not visible (the characters are hidden by asterisks) to any other signer or the sender.  When an envelope is completed the information is available to the sender through the Form Data link in the DocuSign Console.  This setting applies only to text boxes and does not affect list boxes, radio buttons, or check boxes. | [optional] 
**CreatedByDisplayName** | **string** | The user name of the DocuSign user who created this object. | [optional] 
**CreatedByUserId** | **string** | The userId of the DocuSign user who created this object. | [optional] 
**CustomTabId** | **string** | The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties. | [optional] 
**DisableAutoSize** | **string** | When set to **true**, disables the auto sizing of single line text boxes in the signing screen when the signer enters data. If disabled users will only be able enter as much data as the text box can hold. By default this is false. This property only affects single line text boxes. | [optional] 
**Editable** | **string** | When set to **true**, the custom tab is editable. Otherwise the custom tab cannot be modified. | [optional] 
**Font** | **string** | The font to be used for the tab value. Supported Fonts: Arial, Arial, ArialNarrow, Calibri, CourierNew, Garamond, Georgia, Helvetica,   LucidaConsole, Tahoma, TimesNewRoman, Trebuchet, Verdana, MSGothic, MSMincho, Default. | [optional] 
**FontColor** | **string** | The font color used for the information in the tab.  Possible values are: Black, BrightBlue, BrightRed, DarkGreen, DarkRed, Gold, Green, NavyBlue, Purple, or White. | [optional] 
**FontSize** | **string** | The font size used for the information in the tab.  Possible values are: Size7, Size8, Size9, Size10, Size11, Size12, Size14, Size16, Size18, Size20, Size22, Size24, Size26, Size28, Size36, Size48, or Size72. | [optional] 
**Height** | **string** | Height of the tab in pixels. | [optional] 
**IncludedInEmail** | **string** | When set to **true**, the tab is included in e-mails related to the envelope on which it exists. This applies to only specific tabs. | [optional] 
**InitialValue** | **string** | The original value of the tab. | [optional] 
**Italic** | **string** | When set to **true**, the information in the tab is italic. | [optional] 
**Items** | **List&lt;string&gt;** | If the tab is a list, this represents the values that are possible for the tab. | [optional] 
**LastModified** | **string** | The UTC DateTime this object was last modified. This is in ISO8601 format. | [optional] 
**LastModifiedByDisplayName** | **string** | The User Name of the DocuSign user who last modified this object. | [optional] 
**LastModifiedByUserId** | **string** | The userId of the DocuSign user who last modified this object. | [optional] 
**Locked** | **string** | When set to **true**, the signer cannot change the data of the custom tab. | [optional] 
**MaximumLength** | **string** | The maximum number of entry characters supported by the custom tab. | [optional] 
**MergeField** | [**MergeField**](MergeField.md) |  | [optional] 
**Name** | **string** |  | [optional] 
**Required** | **string** | When set to **true**, the signer is required to fill out this tab | [optional] 
**ScaleValue** | **string** |  | [optional] 
**Shared** | **string** | When set to **true**, this custom tab is shared. | [optional] 
**StampType** | **string** |  | [optional] 
**StampTypeMetadata** | [**PropertyMetadata**](PropertyMetadata.md) |  | [optional] 
**TabLabel** | **string** | The label string associated with the tab. The string may be the empty string. If no value is provided, the tab type is used as the value.  Maximum of 500 characters.  | [optional] 
**Type** | **string** | The type of this tab. Values are: Approve, CheckBox, Company, Date, DateSigned, Decline, Email, EmailAddress, EnvelopeId, FirstName, Formula, FullName, InitialHere, InitialHereOptional, LastName, List, Note, Number, Radio, SignerAttachment, SignHere, SignHereOptional, Ssn, Text, Title, Zip5, or Zip5Dash4. | [optional] 
**Underline** | **string** | When set to **true**, the information in the tab is underlined. | [optional] 
**ValidationMessage** | **string** | The message displayed if the custom tab fails input validation (either custom of embedded). | [optional] 
**ValidationPattern** | **string** | A regular expressionn used to validate input for the tab. | [optional] 
**Width** | **string** | Width of the tab in pixels. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

