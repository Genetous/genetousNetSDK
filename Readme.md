## Genetous .Net Framework SDK ##

### Kurulum: ###

Paketi https://www.nuget.org/packages/GenetousSDK adresinden size uygun bir seçenek ile kurun.

### Değişkenleri Belirleme: ###

```csharp
applicationVariables.applicationId = "your appId";
applicationVariables.organizationId = "your orgId";
applicationVariables.clientSecret = "your client secret";
applicationVariables.host = "http://localhost/";
```

### Örnek Login işlemi: ###

```csharp
 Dictionary<string, object> data = new Dictionary<string, object>();
 data.Add("userpass", "your pass");
 data.Add("usermail", "your mail");
 new PostGetBuilder()
     .setData(data)
     .setCompletionHandler(new CompletionHandler((object res) => {
         if (res is string)
         {
             MessageBox.Show(res.ToString());
         }
         else if (res is Dictionary<string, object>)
         {
             Dictionary<string, object> resDic = (Dictionary<string, object>)res;
             if (resDic.ContainsKey("success") && ((bool)resDic["success"]) == true)
             {
                 token.Text = resDic["token"].ToString();
             }
             else
             {
                 MessageBox.Show("Something went wrong!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
             }
         }
     }))
     .build()
     .login();
```