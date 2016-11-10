// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The upload error with properties object</para>
    /// </summary>
    public class UploadErrorWithProperties
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadErrorWithProperties> Encoder = new UploadErrorWithPropertiesEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadErrorWithProperties> Decoder = new UploadErrorWithPropertiesDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadErrorWithProperties" />
        /// class.</para>
        /// </summary>
        public UploadErrorWithProperties()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PropertiesError</para>
        /// </summary>
        public bool IsPropertiesError
        {
            get
            {
                return this is PropertiesError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PropertiesError, or <c>null</c>.</para>
        /// </summary>
        public PropertiesError AsPropertiesError
        {
            get
            {
                return this as PropertiesError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Path</para>
        /// </summary>
        public bool IsPath
        {
            get
            {
                return this is Path;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Path, or <c>null</c>.</para>
        /// </summary>
        public Path AsPath
        {
            get
            {
                return this as Path;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadErrorWithProperties" />.</para>
        /// </summary>
        private class UploadErrorWithPropertiesEncoder : enc.StructEncoder<UploadErrorWithProperties>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadErrorWithProperties value, enc.IJsonWriter writer)
            {
                if (value is PropertiesError)
                {
                    WriteProperty(".tag", "properties_error", writer, enc.StringEncoder.Instance);
                    PropertiesError.Encoder.EncodeFields((PropertiesError)value, writer);
                    return;
                }
                if (value is Path)
                {
                    WriteProperty(".tag", "path", writer, enc.StringEncoder.Instance);
                    Path.Encoder.EncodeFields((Path)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadErrorWithProperties" />.</para>
        /// </summary>
        private class UploadErrorWithPropertiesDecoder : enc.UnionDecoder<UploadErrorWithProperties>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadErrorWithProperties"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadErrorWithProperties Create()
            {
                return new UploadErrorWithProperties();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override UploadErrorWithProperties Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "properties_error":
                        return PropertiesError.Decoder.DecodeFields(reader);
                    case "path":
                        return Path.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The properties error object</para>
        /// </summary>
        public sealed class PropertiesError : UploadErrorWithProperties
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PropertiesError> Encoder = new PropertiesErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PropertiesError> Decoder = new PropertiesErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PropertiesError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public PropertiesError(InvalidPropertyGroupError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PropertiesError" />
            /// class.</para>
            /// </summary>
            private PropertiesError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public InvalidPropertyGroupError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PropertiesError" />.</para>
            /// </summary>
            private class PropertiesErrorEncoder : enc.StructEncoder<PropertiesError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PropertiesError value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Files.InvalidPropertyGroupError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PropertiesError" />.</para>
            /// </summary>
            private class PropertiesErrorDecoder : enc.StructDecoder<PropertiesError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PropertiesError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PropertiesError Create()
                {
                    return new PropertiesError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(PropertiesError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "properties_error":
                            value.Value = Dropbox.Api.Files.InvalidPropertyGroupError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Unable to save the uploaded contents to a file.</para>
        /// </summary>
        public sealed class Path : UploadErrorWithProperties
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Path> Encoder = new PathEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Path> Decoder = new PathDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Path(UploadWriteFailed value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            private Path()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public UploadWriteFailed Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathEncoder : enc.StructEncoder<Path>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Path value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Files.UploadWriteFailed.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathDecoder : enc.StructDecoder<Path>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Path" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Path Create()
                {
                    return new Path();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Path DecodeFields(enc.IJsonReader reader)
                {
                    return new Path(Dropbox.Api.Files.UploadWriteFailed.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : UploadErrorWithProperties
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}