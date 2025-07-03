Middleware are components in the request-processing pipeline that handle HTTP requests and responses in ASP.NET Core.

Request & Response Flow in Middleware
A request enters the pipeline from top to bottom.

Each middleware can do something before and/or after the next one.

The response flows back up the chain ? from the innermost middleware to the outermost.

We have built-in middlewares as well as custom middlewares.