<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="EventID.View.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" type="text/css" href="custom-css.css" />
    <!DOCTYPE link href="https://maps/documentation/javascript/examples/default.css" rel="stylesheet" />
    <html>
    <script src="https://maps.googleapis.com/maps/api/js?v=3.exp&sensor=false" type="text/javascript"></script>
    <script>
        var mapcode;
        var diag;
        function initialize() {
            mapcode = new google.maps.Geocoder();
            var lnt = new google.maps.LatLng(-6.2019, 106.7809);
            var diagChoice = {
                zoom: 16,
                center: lnt,
                diagId: google.maps.MapTypeId.ROADMAP
            }
            diag = new google.maps.Map(document.getElementById('map_populate'), diagChoice);
        }
        google.maps.event.addDomListener(window, 'load', initialize);
    </script>
    </html>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner-contactus"></div>

    <div class="HeaderText">Contact Us</div>
    <div class="contactuscard">
        <p class="text">
            <h2>E-vent.id Office</h2>
            <br />
            <h4 style="font-weight: lighter; color: #e87d1b">Jl. Raya Kb. Jeruk No.27<br />
                021-51112341, 021-31443275<br />
                cs@event.id<br />
                event.id@event.id<br />
            </h4>
        </p>
    </div>
    <div id="map_populate" style="width: 400px; height: 400px; border: 5px solid #5E5454; border-radius: 15px;"></div>
    <br />
    <br />

    
</asp:Content>
