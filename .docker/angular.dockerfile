FROM node 10-alpine

ENV HOME=Contagion/Contagion.angular/src/app
RUN mkdir -p $HOME
WORKDIR $HOME

RUN yarn global add @angular/cli

EXPOSE 4200

USER 1000