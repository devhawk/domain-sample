FROM mcr.microsoft.com/dotnet/core/sdk:3.1-bionic

RUN apt-get update \
    && export DEBIAN_FRONTEND=noninteractive \
    #
    # Neo tools / dependencies
    && apt-get -y --no-install-recommends install git libsnappy-dev libc6-dev \
    && dotnet tool restore \
    #
    # Clean up
    && apt-get autoremove -y \
    && apt-get clean -y \
    && rm -rf /var/lib/apt/lists/*

ENV PATH="${PATH}:/root/.dotnet/tools"
