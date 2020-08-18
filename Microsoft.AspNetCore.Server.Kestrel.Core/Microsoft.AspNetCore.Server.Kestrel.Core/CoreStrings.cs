using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	internal static class CoreStrings
	{
		internal static ResourceManager ResourceManager
		{
			get
			{
				throw null;
			}
		}

		internal static CultureInfo Culture
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>Bad request.</summary>
		internal static string BadRequest
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Bad chunk size data.</summary>
		internal static string BadRequest_BadChunkSizeData
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Bad chunk suffix.</summary>
		internal static string BadRequest_BadChunkSuffix
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Chunked request incomplete.</summary>
		internal static string BadRequest_ChunkedRequestIncomplete
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The message body length cannot be determined because the final transfer coding was set to '{detail}' instead of 'chunked'.</summary>
		internal static string BadRequest_FinalTransferCodingNotChunked
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request headers too long.</summary>
		internal static string BadRequest_HeadersExceedMaxTotalSize
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid characters in header name.</summary>
		internal static string BadRequest_InvalidCharactersInHeaderName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid content length: {detail}</summary>
		internal static string BadRequest_InvalidContentLength_Detail
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid Host header.</summary>
		internal static string BadRequest_InvalidHostHeader
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid Host header: '{detail}'</summary>
		internal static string BadRequest_InvalidHostHeader_Detail
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid request headers: missing final CRLF in header fields.</summary>
		internal static string BadRequest_InvalidRequestHeadersNoCRLF
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid request header: '{detail}'</summary>
		internal static string BadRequest_InvalidRequestHeader_Detail
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid request line.</summary>
		internal static string BadRequest_InvalidRequestLine
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid request line: '{detail}'</summary>
		internal static string BadRequest_InvalidRequestLine_Detail
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid request target: '{detail}'</summary>
		internal static string BadRequest_InvalidRequestTarget_Detail
		{
			get
			{
				throw null;
			}
		}

		/// <summary>{detail} request contains no Content-Length or Transfer-Encoding header.</summary>
		internal static string BadRequest_LengthRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>{detail} request contains no Content-Length header.</summary>
		internal static string BadRequest_LengthRequiredHttp10
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Malformed request: invalid headers.</summary>
		internal static string BadRequest_MalformedRequestInvalidHeaders
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Method not allowed.</summary>
		internal static string BadRequest_MethodNotAllowed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request is missing Host header.</summary>
		internal static string BadRequest_MissingHostHeader
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Multiple Content-Length headers.</summary>
		internal static string BadRequest_MultipleContentLengths
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Multiple Host headers.</summary>
		internal static string BadRequest_MultipleHostHeaders
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request line too long.</summary>
		internal static string BadRequest_RequestLineTooLong
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Reading the request headers timed out.</summary>
		internal static string BadRequest_RequestHeadersTimeout
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request contains too many headers.</summary>
		internal static string BadRequest_TooManyHeaders
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unexpected end of request content.</summary>
		internal static string BadRequest_UnexpectedEndOfRequestContent
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unrecognized HTTP version: '{detail}'</summary>
		internal static string BadRequest_UnrecognizedHTTPVersion
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Requests with 'Connection: Upgrade' cannot have content in the request body.</summary>
		internal static string BadRequest_UpgradeRequestCannotHavePayload
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Failed to bind to http://[::]:{port} (IPv6Any). Attempting to bind to http://0.0.0.0:{port} instead.</summary>
		internal static string FallbackToIPv4Any
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Cannot write to response body after connection has been upgraded.</summary>
		internal static string ResponseStreamWasUpgraded
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Kestrel does not support big-endian architectures.</summary>
		internal static string BigEndianNotSupported
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Maximum request buffer size ({requestBufferSize}) must be greater than or equal to maximum request header size ({requestHeaderSize}).</summary>
		internal static string MaxRequestBufferSmallerThanRequestHeaderBuffer
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Maximum request buffer size ({requestBufferSize}) must be greater than or equal to maximum request line size ({requestLineSize}).</summary>
		internal static string MaxRequestBufferSmallerThanRequestLineBuffer
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Server has already started.</summary>
		internal static string ServerAlreadyStarted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unknown transport mode: '{mode}'.</summary>
		internal static string UnknownTransportMode
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid non-ASCII or control character in header: {character}</summary>
		internal static string InvalidAsciiOrControlChar
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid Content-Length: "{value}". Value must be a positive integral number.</summary>
		internal static string InvalidContentLength_InvalidNumber
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Value must be null or a non-negative number.</summary>
		internal static string NonNegativeNumberOrNullRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Value must be a non-negative number.</summary>
		internal static string NonNegativeNumberRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Value must be a positive number.</summary>
		internal static string PositiveNumberRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Value must be null or a positive number.</summary>
		internal static string PositiveNumberOrNullRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unix socket path must be absolute.</summary>
		internal static string UnixSocketPathMustBeAbsolute
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Failed to bind to address {address}.</summary>
		internal static string AddressBindingFailed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>No listening endpoints were configured. Binding to {address} by default.</summary>
		internal static string BindingToDefaultAddress
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A path base can only be configured using {methodName}.</summary>
		internal static string ConfigurePathBaseFromMethodCall
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Dynamic port binding is not supported when binding to localhost. You must either bind to 127.0.0.1:0 or [::1]:0, or both.</summary>
		internal static string DynamicPortOnLocalhostNotSupported
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Failed to bind to address {endpoint}: address already in use.</summary>
		internal static string EndpointAlreadyInUse
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unable to bind to {address} on the {interfaceName} interface: '{error}'.</summary>
		internal static string NetworkInterfaceBindingFailed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Overriding address(es) '{addresses}'. Binding to endpoints defined in {methodName} instead.</summary>
		internal static string OverridingWithKestrelOptions
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Overriding endpoints defined in UseKestrel() because {settingName} is set to true. Binding to address(es) '{addresses}' instead.</summary>
		internal static string OverridingWithPreferHostingUrls
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unrecognized scheme in server address '{address}'. Only 'http://' and 'https://' are supported.</summary>
		internal static string UnsupportedAddressScheme
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Headers are read-only, response has already started.</summary>
		internal static string HeadersAreReadOnly
		{
			get
			{
				throw null;
			}
		}

		/// <summary>An item with the same key has already been added.</summary>
		internal static string KeyAlreadyExists
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Setting the header {name} is not allowed on responses with status code {statusCode}.</summary>
		internal static string HeaderNotAllowedOnResponse
		{
			get
			{
				throw null;
			}
		}

		/// <summary>{name} cannot be set because the response has already started.</summary>
		internal static string ParameterReadOnlyAfterResponseStarted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Response Content-Length mismatch: too few bytes written ({written} of {expected}).</summary>
		internal static string TooFewBytesWritten
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Response Content-Length mismatch: too many bytes written ({written} of {expected}).</summary>
		internal static string TooManyBytesWritten
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The response has been aborted due to an unhandled application exception.</summary>
		internal static string UnhandledApplicationException
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Writing to the response body is invalid for responses with status code {statusCode}.</summary>
		internal static string WritingToResponseBodyNotSupported
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Connection shutdown abnormally.</summary>
		internal static string ConnectionShutdownError
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Connection processing ended abnormally.</summary>
		internal static string RequestProcessingEndError
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Cannot upgrade a non-upgradable request. Check IHttpUpgradeFeature.IsUpgradableRequest to determine if a request can be upgraded.</summary>
		internal static string CannotUpgradeNonUpgradableRequest
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request cannot be upgraded because the server has already opened the maximum number of upgraded connections.</summary>
		internal static string UpgradedConnectionLimitReached
		{
			get
			{
				throw null;
			}
		}

		/// <summary>IHttpUpgradeFeature.UpgradeAsync was already called and can only be called once per connection.</summary>
		internal static string UpgradeCannotBeCalledMultipleTimes
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request body too large.</summary>
		internal static string BadRequest_RequestBodyTooLarge
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The maximum request body size cannot be modified after the app has already started reading from the request body.</summary>
		internal static string MaxRequestBodySizeCannotBeModifiedAfterRead
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The maximum request body size cannot be modified after the request has been upgraded.</summary>
		internal static string MaxRequestBodySizeCannotBeModifiedForUpgradedRequests
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Value must be a positive TimeSpan.</summary>
		internal static string PositiveTimeSpanRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The request body rate enforcement grace period must be greater than {heartbeatInterval} second.</summary>
		internal static string MinimumGracePeriodRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Synchronous operations are disallowed. Call ReadAsync or set AllowSynchronousIO to true instead.</summary>
		internal static string SynchronousReadsDisallowed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Synchronous operations are disallowed. Call WriteAsync or set AllowSynchronousIO to true instead.</summary>
		internal static string SynchronousWritesDisallowed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Value must be a positive number. To disable a minimum data rate, use null where a MinDataRate instance is expected.</summary>
		internal static string PositiveNumberOrNullMinDataRateRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Concurrent timeouts are not supported.</summary>
		internal static string ConcurrentTimeoutsNotSupported
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Timespan must be positive and finite.</summary>
		internal static string PositiveFiniteTimeSpanRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>An endpoint must be configured to serve at least one protocol.</summary>
		internal static string EndPointRequiresAtLeastOneProtocol
		{
			get
			{
				throw null;
			}
		}

		/// <summary>HTTP/2 over TLS was not negotiated on an HTTP/2-only endpoint.</summary>
		internal static string EndPointHttp2NotNegotiated
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame with even stream ID {streamId}.</summary>
		internal static string Http2ErrorStreamIdEven
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a A PUSH_PROMISE frame.</summary>
		internal static string Http2ErrorPushPromiseReceived
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame to stream ID {streamId} before signaling of the header block for stream ID {headersStreamId}.</summary>
		internal static string Http2ErrorHeadersInterleaved
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame with stream ID 0.</summary>
		internal static string Http2ErrorStreamIdZero
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame with stream ID different than 0.</summary>
		internal static string Http2ErrorStreamIdNotZero
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame with padding longer than or with the same length as the sent data.</summary>
		internal static string Http2ErrorPaddingTooLong
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame to closed stream ID {streamId}.</summary>
		internal static string Http2ErrorStreamClosed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame to stream ID {streamId} which is in the "half-closed (remote) state".</summary>
		internal static string Http2ErrorStreamHalfClosedRemote
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame with dependency information that would cause stream ID {streamId} to depend on itself.</summary>
		internal static string Http2ErrorStreamSelfDependency
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame with length different than {expectedLength}.</summary>
		internal static string Http2ErrorUnexpectedFrameLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a SETTINGS frame with a length that is not a multiple of 6.</summary>
		internal static string Http2ErrorSettingsLengthNotMultipleOfSix
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a SETTINGS frame with ACK set and length different than 0.</summary>
		internal static string Http2ErrorSettingsAckLengthNotZero
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a SETTINGS frame with a value for parameter {parameter} that is out of range.</summary>
		internal static string Http2ErrorSettingsParameterOutOfRange
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a WINDOW_UPDATE frame with a window size increment of 0.</summary>
		internal static string Http2ErrorWindowUpdateIncrementZero
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a CONTINUATION frame not preceded by a HEADERS frame.</summary>
		internal static string Http2ErrorContinuationWithNoHeaders
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a {frameType} frame to idle stream ID {streamId}.</summary>
		internal static string Http2ErrorStreamIdle
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent trailers containing one or more pseudo-header fields.</summary>
		internal static string Http2ErrorTrailersContainPseudoHeaderField
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a header with uppercase characters in its name.</summary>
		internal static string Http2ErrorHeaderNameUppercase
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a trailer with uppercase characters in its name.</summary>
		internal static string Http2ErrorTrailerNameUppercase
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a HEADERS frame containing trailers without setting the END_STREAM flag.</summary>
		internal static string Http2ErrorHeadersWithTrailersNoEndStream
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request headers missing one or more mandatory pseudo-header fields.</summary>
		internal static string Http2ErrorMissingMandatoryPseudoHeaderFields
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Pseudo-header field found in request headers after regular header fields.</summary>
		internal static string Http2ErrorPseudoHeaderFieldAfterRegularHeaders
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request headers contain unknown pseudo-header field.</summary>
		internal static string Http2ErrorUnknownPseudoHeaderField
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request headers contain response-specific pseudo-header field.</summary>
		internal static string Http2ErrorResponsePseudoHeaderField
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request headers contain duplicate pseudo-header field.</summary>
		internal static string Http2ErrorDuplicatePseudoHeaderField
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request headers contain connection-specific header field.</summary>
		internal static string Http2ErrorConnectionSpecificHeaderField
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Failed to authenticate HTTPS connection.</summary>
		internal static string AuthenticationFailed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Authentication of the HTTPS connection timed out.</summary>
		internal static string AuthenticationTimedOut
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Certificate {thumbprint} cannot be used as an SSL server certificate. It has an Extended Key Usage extension but the usages do not include Server Authentication (OID 1.3.6.1.5.5.7.3.1).</summary>
		internal static string InvalidServerCertificateEku
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The server certificate parameter is required.</summary>
		internal static string ServerCertificateRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>No listening endpoints were configured. Binding to {address0} and {address1} by default.</summary>
		internal static string BindingToDefaultAddresses
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The requested certificate {subject} could not be found in {storeLocation}/{storeName} with AllowInvalid setting: {allowInvalid}.</summary>
		internal static string CertNotFoundInStore
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The endpoint {endpointName} is missing the required 'Url' parameter.</summary>
		internal static string EndpointMissingUrl
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unable to configure HTTPS endpoint. No server certificate was specified, and the default developer certificate could not be found or is out of date.
		/// To generate a developer certificate run 'dotnet dev-certs https'. To trust the certificate (Windows and mac ...</summary>
		internal static string NoCertSpecifiedNoDevelopmentCertificateFound
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The endpoint {endpointName} specified multiple certificate sources.</summary>
		internal static string MultipleCertificateSources
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Cannot write to the response body, the response has completed.</summary>
		internal static string WritingToResponseBodyAfterResponseCompleted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Reading the request body timed out due to data arriving too slowly. See MinRequestBodyDataRate.</summary>
		internal static string BadRequest_RequestBodyTimeout
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The connection was aborted by the application.</summary>
		internal static string ConnectionAbortedByApplication
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The connection was aborted because the server is shutting down and request processing didn't complete within the time specified by HostOptions.ShutdownTimeout.</summary>
		internal static string ConnectionAbortedDuringServerShutdown
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The connection was timed out by the server because the response was not read by the client at the specified minimum data rate.</summary>
		internal static string ConnectionTimedBecauseResponseMininumDataRateNotSatisfied
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The connection was timed out by the server.</summary>
		internal static string ConnectionTimedOutByServer
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The received frame size of {size} exceeds the limit {limit}.</summary>
		internal static string Http2ErrorFrameOverLimit
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Tls 1.2 or later must be used for HTTP/2. {protocol} was negotiated.</summary>
		internal static string Http2ErrorMinTlsVersion
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid HTTP/2 connection preface.</summary>
		internal static string Http2ErrorInvalidPreface
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Header name cannot be a null or empty string.</summary>
		internal static string InvalidEmptyHeaderName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The connection or stream was aborted because a write operation was aborted with a CancellationToken.</summary>
		internal static string ConnectionOrStreamAbortedByCancellationToken
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a SETTINGS frame with a SETTINGS_INITIAL_WINDOW_SIZE that caused a flow-control window to exceed the maximum size.</summary>
		internal static string Http2ErrorInitialWindowSizeInvalid
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent a WINDOW_UPDATE frame that caused a flow-control window to exceed the maximum size.</summary>
		internal static string Http2ErrorWindowUpdateSizeInvalid
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The HTTP/2 connection faulted.</summary>
		internal static string Http2ConnectionFaulted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client reset the request stream.</summary>
		internal static string Http2StreamResetByClient
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The request stream was aborted.</summary>
		internal static string Http2StreamAborted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client sent more data than what was available in the flow-control window.</summary>
		internal static string Http2ErrorFlowControlWindowExceeded
		{
			get
			{
				throw null;
			}
		}

		/// <summary>CONNECT requests must not send :scheme or :path headers.</summary>
		internal static string Http2ErrorConnectMustNotSendSchemeOrPath
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The Method '{method}' is invalid.</summary>
		internal static string Http2ErrorMethodInvalid
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The request :path is invalid: '{path}'</summary>
		internal static string Http2StreamErrorPathInvalid
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The request :scheme header '{requestScheme}' does not match the transport scheme '{transportScheme}'.</summary>
		internal static string Http2StreamErrorSchemeMismatch
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Less data received than specified in the Content-Length header.</summary>
		internal static string Http2StreamErrorLessDataThanLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>More data received than specified in the Content-Length header.</summary>
		internal static string Http2StreamErrorMoreDataThanLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>An error occurred after the response headers were sent, a reset is being sent.</summary>
		internal static string Http2StreamErrorAfterHeaders
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A new stream was refused because this connection has reached its stream limit.</summary>
		internal static string Http2ErrorMaxStreams
		{
			get
			{
				throw null;
			}
		}

		/// <summary>CONNECT requests must not send :scheme or :path headers.</summary>
		internal static string Http3ErrorConnectMustNotSendSchemeOrPath
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The request :scheme header '{requestScheme}' does not match the transport scheme '{transportScheme}'.</summary>
		internal static string Http3StreamErrorSchemeMismatch
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The Method '{method}' is invalid.</summary>
		internal static string Http3ErrorMethodInvalid
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The request :path is invalid: '{path}'</summary>
		internal static string Http3StreamErrorPathInvalid
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Less data received than specified in the Content-Length header.</summary>
		internal static string Http3StreamErrorLessDataThanLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>More data received than specified in the Content-Length header.</summary>
		internal static string Http3StreamErrorMoreDataThanLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A value greater than zero is required.</summary>
		internal static string GreaterThanZeroRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A value between {min} and {max} is required.</summary>
		internal static string ArgumentOutOfRange
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The client closed the connection.</summary>
		internal static string ConnectionAbortedByClient
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A frame of type {frameType} was received after stream {streamId} was reset or aborted.</summary>
		internal static string Http2ErrorStreamAborted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>This feature is not supported for HTTP/2 requests except to disable it entirely by setting the rate to null.</summary>
		internal static string Http2MinDataRateNotSupported
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The request trailers are not available yet. They may not be available until the full request body is read.</summary>
		internal static string RequestTrailersNotAvailable
		{
			get
			{
				throw null;
			}
		}

		/// <summary>HTTP/2 over TLS is not supported on macOS due to missing ALPN support.</summary>
		internal static string Http2NoTlsOsx
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The HTTP/2 stream was reset by the application with error code {errorCode}.</summary>
		internal static string Http2StreamResetByApplication
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A new stream was refused because this connection has too many streams that haven't finished processing. This may happen if many streams are aborted but not yet cleaned up.</summary>
		internal static string Http2TellClientToCalmDown
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Detected a TLS handshake to an endpoint that does not have TLS enabled.</summary>
		internal static string HttpParserTlsOverHttpError
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The ASP.NET Core developer certificate is in an invalid state. To fix this issue, run the following commands 'dotnet dev-certs https --clean' and 'dotnet dev-certs https' to remove all existing ASP.NET Core development certificates and create a new untrust ...</summary>
		internal static string BadDeveloperCertificateState
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Index {index} is outside the bounds of the header field table.</summary>
		internal static string QPackErrorIndexOutOfRange
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The decoded integer exceeds the maximum value of Int32.MaxValue.</summary>
		internal static string QPackErrorIntegerTooBig
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Huffman decoding error.</summary>
		internal static string QPackHuffmanError
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Decoded string length of {length} octets is greater than the configured maximum length of {maxStringLength} octets.</summary>
		internal static string QPackStringLengthTooLarge
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Quic transport not found when using HTTP/3.</summary>
		internal static string QuicTransportNotFound
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unable to resolve service for type 'Microsoft.AspNetCore.Connections.IConnectionListenerFactory' while attempting to activate 'Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServer'.</summary>
		internal static string TransportNotFound
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A value greater than or equal to zero is required.</summary>
		internal static string GreaterThanOrEqualToZeroRequired
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Connection "{connectionId}" established using the following protocol: {protocol}</summary>
		internal static string HttpsConnectionEstablished
		{
			get
			{
				throw null;
			}
		}

		/// <summary>HTTP/2 over TLS is not supported on Windows versions older than Windows 10 and Windows Server 2016 due to incompatible ciphers or missing ALPN support. Falling back to HTTP/1.1 instead.</summary>
		internal static string Http2DefaultCiphersInsufficient
		{
			get
			{
				throw null;
			}
		}

		/// <summary>HTTP/2 over TLS is not supported on Windows versions earlier than Windows 10 and Windows Server 2016 due to incompatible ciphers or missing ALPN support.</summary>
		internal static string Http2NoTlsWin81
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Timeout while waiting for incoming HTTP/2 frames after a keep alive ping.</summary>
		internal static string Http2ErrorKeepAliveTimeout
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A TimeSpan value greater than or equal to {value} is required.</summary>
		internal static string ArgumentTimeSpanGreaterOrEqual
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The provided key file is missing or invalid.</summary>
		internal static string InvalidPemKey
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unknown algorithm for certificate with public key type '{0}'.</summary>
		internal static string UnrecognizedCertificateKeyOid
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Connection refused because no SNI configuration section was found for '{serverName}' in '{endpointName}'. To allow all connections, add a wildcard ('*') SNI section.</summary>
		internal static string SniNotConfiguredForServerName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Connection refused because the client did not specify a server name, and no wildcard ('*') SNI configuration section was found in '{endpointName}'.</summary>
		internal static string SniNotConfiguredToAllowNoServerName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The endpoint {endpointName} is invalid because an SNI configuration section has an empty string as its key. Use a wildcard ('*') SNI section to match all server names.</summary>
		internal static string SniNameCannotBeEmpty
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The non-HTTPS endpoint {endpointName} includes HTTPS-only configuration for {keyName}.</summary>
		internal static string EndpointHasUnusedHttpsConfig
		{
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static string GetResourceString(string resourceKey, string defaultValue = null)
		{
			throw null;
		}

		/// <summary>The message body length cannot be determined because the final transfer coding was set to '{detail}' instead of 'chunked'.</summary>
		internal static string FormatBadRequest_FinalTransferCodingNotChunked(object detail)
		{
			throw null;
		}

		/// <summary>Invalid content length: {detail}</summary>
		internal static string FormatBadRequest_InvalidContentLength_Detail(object detail)
		{
			throw null;
		}

		/// <summary>Invalid Host header: '{detail}'</summary>
		internal static string FormatBadRequest_InvalidHostHeader_Detail(object detail)
		{
			throw null;
		}

		/// <summary>Invalid request header: '{detail}'</summary>
		internal static string FormatBadRequest_InvalidRequestHeader_Detail(object detail)
		{
			throw null;
		}

		/// <summary>Invalid request line: '{detail}'</summary>
		internal static string FormatBadRequest_InvalidRequestLine_Detail(object detail)
		{
			throw null;
		}

		/// <summary>Invalid request target: '{detail}'</summary>
		internal static string FormatBadRequest_InvalidRequestTarget_Detail(object detail)
		{
			throw null;
		}

		/// <summary>{detail} request contains no Content-Length or Transfer-Encoding header.</summary>
		internal static string FormatBadRequest_LengthRequired(object detail)
		{
			throw null;
		}

		/// <summary>{detail} request contains no Content-Length header.</summary>
		internal static string FormatBadRequest_LengthRequiredHttp10(object detail)
		{
			throw null;
		}

		/// <summary>Unrecognized HTTP version: '{detail}'</summary>
		internal static string FormatBadRequest_UnrecognizedHTTPVersion(object detail)
		{
			throw null;
		}

		/// <summary>Failed to bind to http://[::]:{port} (IPv6Any). Attempting to bind to http://0.0.0.0:{port} instead.</summary>
		internal static string FormatFallbackToIPv4Any(object port)
		{
			throw null;
		}

		/// <summary>Maximum request buffer size ({requestBufferSize}) must be greater than or equal to maximum request header size ({requestHeaderSize}).</summary>
		internal static string FormatMaxRequestBufferSmallerThanRequestHeaderBuffer(object requestBufferSize, object requestHeaderSize)
		{
			throw null;
		}

		/// <summary>Maximum request buffer size ({requestBufferSize}) must be greater than or equal to maximum request line size ({requestLineSize}).</summary>
		internal static string FormatMaxRequestBufferSmallerThanRequestLineBuffer(object requestBufferSize, object requestLineSize)
		{
			throw null;
		}

		/// <summary>Unknown transport mode: '{mode}'.</summary>
		internal static string FormatUnknownTransportMode(object mode)
		{
			throw null;
		}

		/// <summary>Invalid non-ASCII or control character in header: {character}</summary>
		internal static string FormatInvalidAsciiOrControlChar(object character)
		{
			throw null;
		}

		/// <summary>Invalid Content-Length: "{value}". Value must be a positive integral number.</summary>
		internal static string FormatInvalidContentLength_InvalidNumber(object value)
		{
			throw null;
		}

		/// <summary>Failed to bind to address {address}.</summary>
		internal static string FormatAddressBindingFailed(object address)
		{
			throw null;
		}

		/// <summary>No listening endpoints were configured. Binding to {address} by default.</summary>
		internal static string FormatBindingToDefaultAddress(object address)
		{
			throw null;
		}

		/// <summary>A path base can only be configured using {methodName}.</summary>
		internal static string FormatConfigurePathBaseFromMethodCall(object methodName)
		{
			throw null;
		}

		/// <summary>Failed to bind to address {endpoint}: address already in use.</summary>
		internal static string FormatEndpointAlreadyInUse(object endpoint)
		{
			throw null;
		}

		/// <summary>Unable to bind to {address} on the {interfaceName} interface: '{error}'.</summary>
		internal static string FormatNetworkInterfaceBindingFailed(object address, object interfaceName, object error)
		{
			throw null;
		}

		/// <summary>Overriding address(es) '{addresses}'. Binding to endpoints defined in {methodName} instead.</summary>
		internal static string FormatOverridingWithKestrelOptions(object addresses, object methodName)
		{
			throw null;
		}

		/// <summary>Overriding endpoints defined in UseKestrel() because {settingName} is set to true. Binding to address(es) '{addresses}' instead.</summary>
		internal static string FormatOverridingWithPreferHostingUrls(object settingName, object addresses)
		{
			throw null;
		}

		/// <summary>Unrecognized scheme in server address '{address}'. Only 'http://' and 'https://' are supported.</summary>
		internal static string FormatUnsupportedAddressScheme(object address)
		{
			throw null;
		}

		/// <summary>Setting the header {name} is not allowed on responses with status code {statusCode}.</summary>
		internal static string FormatHeaderNotAllowedOnResponse(object name, object statusCode)
		{
			throw null;
		}

		/// <summary>{name} cannot be set because the response has already started.</summary>
		internal static string FormatParameterReadOnlyAfterResponseStarted(object name)
		{
			throw null;
		}

		/// <summary>Response Content-Length mismatch: too few bytes written ({written} of {expected}).</summary>
		internal static string FormatTooFewBytesWritten(object written, object expected)
		{
			throw null;
		}

		/// <summary>Response Content-Length mismatch: too many bytes written ({written} of {expected}).</summary>
		internal static string FormatTooManyBytesWritten(object written, object expected)
		{
			throw null;
		}

		/// <summary>Writing to the response body is invalid for responses with status code {statusCode}.</summary>
		internal static string FormatWritingToResponseBodyNotSupported(object statusCode)
		{
			throw null;
		}

		/// <summary>The request body rate enforcement grace period must be greater than {heartbeatInterval} second.</summary>
		internal static string FormatMinimumGracePeriodRequired(object heartbeatInterval)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame with even stream ID {streamId}.</summary>
		internal static string FormatHttp2ErrorStreamIdEven(object frameType, object streamId)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame to stream ID {streamId} before signaling of the header block for stream ID {headersStreamId}.</summary>
		internal static string FormatHttp2ErrorHeadersInterleaved(object frameType, object streamId, object headersStreamId)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame with stream ID 0.</summary>
		internal static string FormatHttp2ErrorStreamIdZero(object frameType)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame with stream ID different than 0.</summary>
		internal static string FormatHttp2ErrorStreamIdNotZero(object frameType)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame with padding longer than or with the same length as the sent data.</summary>
		internal static string FormatHttp2ErrorPaddingTooLong(object frameType)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame to closed stream ID {streamId}.</summary>
		internal static string FormatHttp2ErrorStreamClosed(object frameType, object streamId)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame to stream ID {streamId} which is in the "half-closed (remote) state".</summary>
		internal static string FormatHttp2ErrorStreamHalfClosedRemote(object frameType, object streamId)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame with dependency information that would cause stream ID {streamId} to depend on itself.</summary>
		internal static string FormatHttp2ErrorStreamSelfDependency(object frameType, object streamId)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame with length different than {expectedLength}.</summary>
		internal static string FormatHttp2ErrorUnexpectedFrameLength(object frameType, object expectedLength)
		{
			throw null;
		}

		/// <summary>The client sent a SETTINGS frame with a value for parameter {parameter} that is out of range.</summary>
		internal static string FormatHttp2ErrorSettingsParameterOutOfRange(object parameter)
		{
			throw null;
		}

		/// <summary>The client sent a {frameType} frame to idle stream ID {streamId}.</summary>
		internal static string FormatHttp2ErrorStreamIdle(object frameType, object streamId)
		{
			throw null;
		}

		/// <summary>Certificate {thumbprint} cannot be used as an SSL server certificate. It has an Extended Key Usage extension but the usages do not include Server Authentication (OID 1.3.6.1.5.5.7.3.1).</summary>
		internal static string FormatInvalidServerCertificateEku(object thumbprint)
		{
			throw null;
		}

		/// <summary>No listening endpoints were configured. Binding to {address0} and {address1} by default.</summary>
		internal static string FormatBindingToDefaultAddresses(object address0, object address1)
		{
			throw null;
		}

		/// <summary>The requested certificate {subject} could not be found in {storeLocation}/{storeName} with AllowInvalid setting: {allowInvalid}.</summary>
		internal static string FormatCertNotFoundInStore(object subject, object storeLocation, object storeName, object allowInvalid)
		{
			throw null;
		}

		/// <summary>The endpoint {endpointName} is missing the required 'Url' parameter.</summary>
		internal static string FormatEndpointMissingUrl(object endpointName)
		{
			throw null;
		}

		/// <summary>The endpoint {endpointName} specified multiple certificate sources.</summary>
		internal static string FormatMultipleCertificateSources(object endpointName)
		{
			throw null;
		}

		/// <summary>The received frame size of {size} exceeds the limit {limit}.</summary>
		internal static string FormatHttp2ErrorFrameOverLimit(object size, object limit)
		{
			throw null;
		}

		/// <summary>Tls 1.2 or later must be used for HTTP/2. {protocol} was negotiated.</summary>
		internal static string FormatHttp2ErrorMinTlsVersion(object protocol)
		{
			throw null;
		}

		/// <summary>The Method '{method}' is invalid.</summary>
		internal static string FormatHttp2ErrorMethodInvalid(object method)
		{
			throw null;
		}

		/// <summary>The request :path is invalid: '{path}'</summary>
		internal static string FormatHttp2StreamErrorPathInvalid(object path)
		{
			throw null;
		}

		/// <summary>The request :scheme header '{requestScheme}' does not match the transport scheme '{transportScheme}'.</summary>
		internal static string FormatHttp2StreamErrorSchemeMismatch(object requestScheme, object transportScheme)
		{
			throw null;
		}

		/// <summary>The request :scheme header '{requestScheme}' does not match the transport scheme '{transportScheme}'.</summary>
		internal static string FormatHttp3StreamErrorSchemeMismatch(object requestScheme, object transportScheme)
		{
			throw null;
		}

		/// <summary>The Method '{method}' is invalid.</summary>
		internal static string FormatHttp3ErrorMethodInvalid(object method)
		{
			throw null;
		}

		/// <summary>The request :path is invalid: '{path}'</summary>
		internal static string FormatHttp3StreamErrorPathInvalid(object path)
		{
			throw null;
		}

		/// <summary>A value between {min} and {max} is required.</summary>
		internal static string FormatArgumentOutOfRange(object min, object max)
		{
			throw null;
		}

		/// <summary>A frame of type {frameType} was received after stream {streamId} was reset or aborted.</summary>
		internal static string FormatHttp2ErrorStreamAborted(object frameType, object streamId)
		{
			throw null;
		}

		/// <summary>The HTTP/2 stream was reset by the application with error code {errorCode}.</summary>
		internal static string FormatHttp2StreamResetByApplication(object errorCode)
		{
			throw null;
		}

		/// <summary>Index {index} is outside the bounds of the header field table.</summary>
		internal static string FormatQPackErrorIndexOutOfRange(object index)
		{
			throw null;
		}

		/// <summary>Decoded string length of {length} octets is greater than the configured maximum length of {maxStringLength} octets.</summary>
		internal static string FormatQPackStringLengthTooLarge(object length, object maxStringLength)
		{
			throw null;
		}

		/// <summary>Connection "{connectionId}" established using the following protocol: {protocol}</summary>
		internal static string FormatHttpsConnectionEstablished(object connectionId, object protocol)
		{
			throw null;
		}

		/// <summary>A TimeSpan value greater than or equal to {value} is required.</summary>
		internal static string FormatArgumentTimeSpanGreaterOrEqual(object value)
		{
			throw null;
		}

		/// <summary>Unknown algorithm for certificate with public key type '{0}'.</summary>
		internal static string FormatUnrecognizedCertificateKeyOid(object p0)
		{
			throw null;
		}

		/// <summary>Connection refused because no SNI configuration section was found for '{serverName}' in '{endpointName}'. To allow all connections, add a wildcard ('*') SNI section.</summary>
		internal static string FormatSniNotConfiguredForServerName(object serverName, object endpointName)
		{
			throw null;
		}

		/// <summary>Connection refused because the client did not specify a server name, and no wildcard ('*') SNI configuration section was found in '{endpointName}'.</summary>
		internal static string FormatSniNotConfiguredToAllowNoServerName(object endpointName)
		{
			throw null;
		}

		/// <summary>The endpoint {endpointName} is invalid because an SNI configuration section has an empty string as its key. Use a wildcard ('*') SNI section to match all server names.</summary>
		internal static string FormatSniNameCannotBeEmpty(object endpointName)
		{
			throw null;
		}

		/// <summary>The non-HTTPS endpoint {endpointName} includes HTTPS-only configuration for {keyName}.</summary>
		internal static string FormatEndpointHasUnusedHttpsConfig(object endpointName, object keyName)
		{
			throw null;
		}
	}
}
