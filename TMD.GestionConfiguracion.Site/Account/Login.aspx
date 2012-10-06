<%@ Page Title="Log In" Language="C#" MasterPageFile="~/SitePublic.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="TMD.CF.Site.Account.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Log In
    </h2>
    <p>
        Por favor ingrese su user y password.
        <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false">Registrese </asp:HyperLink>si usted no tiene con una cuenta.
    </p>
    <asp:Login ID="LoginUser" runat="server" EnableViewState="false" 
    RenderOuterTable="false" MembershipProvider="None" 
    onauthenticate="LoginUser_Authenticate" 
        
        FailureText="Su intento de inicio de sesión no se realizó correctamente. Por favor, inténtelo de nuevo." 
        DestinationPageUrl="~/Index.aspx">
        <LayoutTemplate>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="login">
                    <legend>Informaci&oacute;n de la cuenta.</legend>
                    <p>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User:</asp:Label>
                        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                             CssClass="failureNotification" ErrorMessage="El User es requerido." ToolTip="El User es requerido." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" 
                            TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" ErrorMessage="El Password es requerido." ToolTip="El Password es requerido." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:CheckBox ID="RememberMe" runat="server"/>
                        <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" 
                            CssClass="inline" Width="114px">No cerrar sesi&oacute;n.</asp:Label>
                    </p>
                </fieldset>
                <p class="submitButton">
                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" 
                        ValidationGroup="LoginUserValidationGroup" onclick="LoginButton_Click"/>
                </p>
            </div>
        </LayoutTemplate>
    </asp:Login>
</asp:Content>
