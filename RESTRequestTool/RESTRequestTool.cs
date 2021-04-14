using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTRequestTool
{
    public partial class RESTRequestTool : Form
    {
        public RESTRequestTool()
        {
            InitializeComponent();
        }
        public async Task<string> TriggerRestRequest()
        {
            CancellationTokenSource CancellationEventSource = new CancellationTokenSource();
            var token = CancellationEventSource.Token;
            string responseString = string.Empty;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                    using (var client = new HttpClient())
                    {
                        client.Timeout = TimeSpan.FromMinutes(Convert.ToInt16(txtWaitTime.Text));
                        using (var request =
                            new HttpRequestMessage(new HttpMethod(cmbType.Text), txtUrl.Text))
                        {
                            using (var stringContent = new StringContent(txtRequest.Text, Encoding.UTF8,
                                "application/json"))
                            {
                                request.Content = stringContent;
                                using (var response = await client
                                    .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, token)
                                    .ConfigureAwait(true))
                                {
                                    response?.EnsureSuccessStatusCode();
                                    using (Stream receiveStream = await response?.Content?.ReadAsStreamAsync())
                                    {
                                        using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                                        {
                                            responseString = await readStream?.ReadToEndAsync();
                                        }

                                        txtResponse.Text = responseString;
                                    }
                                }
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                txtResponse.Text = "An application error occurred."+ ex.StackTrace;

            }
            finally
            {
                CancellationEventSource.Dispose();
            }

            return responseString;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!String.IsNullOrWhiteSpace((txtRequest.Text)))
                                                                 && (!String.IsNullOrWhiteSpace((txtUrl.Text))) &&
                                                                 (!String.IsNullOrWhiteSpace((cmbType.Text)))
                                                                 && (!String.IsNullOrWhiteSpace((txtWaitTime.Text))))
                {
                    txtResponse.Text = string.Empty;
                    TriggerRestRequest();
                }
                else
                {
                    txtResponse.Text = "All fields are not updated !!";
                }
            }
            catch (Exception ex)
            {
                txtResponse.Text = "An application error occurred. "+ex.StackTrace;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtResponse.Text))
            {
                txtResponse.Text = string.Empty;
            }
        }
    }
}
