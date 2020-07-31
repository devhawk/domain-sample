FROM mcr.microsoft.com/dotnet/core/sdk:3.1-bionic

RUN apt-get update \
    && export DEBIAN_FRONTEND=noninteractive \
    #
    # Neo tools / dependencies
    && dotnet tool install -g neo.neon \
    && dotnet tool install -g neo.express \
    && apt-get -y --no-install-recommends install git libsnappy-dev libc6-dev \
    #
    # Clean up
    && apt-get autoremove -y \
    && apt-get clean -y \
    && rm -rf /var/lib/apt/lists/*

ENV PATH="${PATH}:/root/.dotnet/tools"
