# bitbucket-server-webhooks

This repo is an simple example of using `Microsoft.AspNetCore.WebHooks.Receivers.BitBucket` for Bitbucket Server 5.7.1.

## Setup

### Visual Studio

_Note: If you are running Bitbucket Server in a docker, below are is what I had to do to get the webhooks properly sending data to the api running from iisexpress._

1. Open _<repo folder>/BitbucketServerWebHooks/.vs/config/applicationhost.config_ and search for `bindingInformation` (make sure you edit only the one under `<site name="BitbucketServerWebHooks"...>`).

```
// Previous
<binding protocol="http" bindingInformation="*:61150:localhost" />

// New
<binding protocol="http" bindingInformation=":61150:" />
```

2. Run Visual Studio as an administrator.
