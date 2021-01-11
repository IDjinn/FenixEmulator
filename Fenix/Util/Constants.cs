﻿using System;
using System.Text;

namespace Server.Util
{
    public static class Constants
    {
        public const string POLICY_REQUEST_ID = "<policy-file-request/>";
        public static ReadOnlyMemory<byte> POLICY_REQUEST_RESPONSE = Encoding.UTF8.GetBytes("<?xml version=\"1.0\"?>\n" +
            "  <!DOCTYPE cross-domain-policy SYSTEM \"/xml/dtds/cross-domain-policy.dtd\">\n" +
            "  <cross-domain-policy>\n" +
            "  <allow-access-from domain=\"*\" to-ports=\"1-31111\" />\n" +
            "  </cross-domain-policy>" + (char)0);

        public const string RSA_N = "86851dd364d5c5cece3c883171cc6ddc5760779b992482bd1e20dd296888df91b33b936a7b93f06d29e8870f703a216257dec7c81de0058fea4cc5116f75e6efc4e9113513e45357dc3fd43d4efab5963ef178b78bd61e81a14c603b24c8bcce0a12230b320045498edc29282ff0603bc7b7dae8fc1b05b52b2f301a9dc783b7";
        public const string RSA_D = "59ae13e243392e89ded305764bdd9e92e4eafa67bb6dac7e1415e8c645b0950bccd26246fd0d4af37145af5fa026c0ec3a94853013eaae5ff1888360f4f9449ee023762ec195dff3f30ca0b08b8c947e3859877b5d7dced5c8715c58b53740b84e11fbc71349a27c31745fcefeeea57cff291099205e230e0c7c27e8e1c0512b";
        public const string RSA_E = "3";
    }
}
