Imports System.ComponentModel.DataAnnotations

Namespace JQueryValidation.Models

    Public Class ValidationData

        <Required(ErrorMessage:="Name is required")>
        <StringLength(50, ErrorMessage:="Must be under 50 characters")>
        Public Property Name As String

        <Range(18, 100, ErrorMessage:="Must be between 18 and 100")>
        Public Property Age As Integer?

        <Required(ErrorMessage:="Email is required")>
        <RegularExpression("\w+([-+.\']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage:="Email is invalid")>
        Public Property Email As String

        <Required(ErrorMessage:="Arrival date is required")>
        Public Property ArrivalDate As Date?
    End Class
End Namespace
